using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool canMove = true;

    [SerializeField]
    float maxPos;

    [SerializeField]
    float MoveSpeed;
    void Start()
    {
        
    }



    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }

    private void Move()
    {
        
        float inputX = Input.GetAxis("Horizontal");

        transform.position += Vector3.right *inputX * MoveSpeed * Time.deltaTime;

        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }

}
