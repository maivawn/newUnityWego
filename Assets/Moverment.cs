using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverment : MonoBehaviour
{
    public float speed = 5f;
     public Rigidbody body;

   
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = -1;

        }
        else if(Input.GetKey(KeyCode.LeftShift)) { speed = 1; }
        else if(Input.GetKey(KeyCode.RightShift)) { speed = 1; }
        else speed = 0;
        transform.Translate(Vector3.right * speed* Time.deltaTime);
    }

    
}
