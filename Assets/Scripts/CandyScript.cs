using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{


    void Start()
    {
        
    }



    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            GameManger.instance.IncrementScore();
            Destroy(gameObject);
        }

        else if(collider.gameObject.tag == "Boundary")
        {
            GameManger.instance.DecreaseLives();
            Destroy(gameObject);
        }

    }


}
