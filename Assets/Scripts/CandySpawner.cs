using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{

    [SerializeField]
    float maxX;

    public GameObject Milk;

    public float spawnInterval;

    public static CandySpawner instance;

    private void Awake() {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Start()
    {
        //SpawnCandy();
        StartSpawningCandies();
    
    }

    void Update()
    {
        
    }

    void SpawnCandy()
    {

        float randomX = Random.Range(-maxX , maxX);
        Vector3 randomPos = new Vector3 (randomX, transform.position.y, transform.position.z);

        Instantiate(Milk, randomPos, transform.rotation);
    }


    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds (1f);

        while (true)
        {
            SpawnCandy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandies");
    }


}
