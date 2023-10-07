using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    public int playerNumber;

    void FixedUpdate()
    {
        if (playerNumber == 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-Vector3.up * speed);
            }
        }
        else if (playerNumber == 2)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * speed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(-Vector3.up * speed);
            }
        }

        //if the y is beyond 6
        if (transform.position.y > 6)
        {
            transform.position = new Vector3(transform.position.x, 6, transform.position.z);
        }

        //if the y is beyond -4
        if (transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x, -4, transform.position.z);
        }
    }
}
