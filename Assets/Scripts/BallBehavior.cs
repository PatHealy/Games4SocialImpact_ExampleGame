using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private Rigidbody2D rb;
    public float pushForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(Vector2.right * pushForce);
    }

    public void Serve()
    {
        if (Random.value > 0.5f)
        {
            rb.AddForce(Vector2.right * pushForce);
        }
        else
        {
            rb.AddForce(-Vector2.right * pushForce);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = collision.collider.gameObject;
        PaddleController playerController = player.GetComponent<PaddleController>();

        if (playerController != null)
        {
            if (playerController.playerNumber == 1)
            {
                rb.AddForce(Vector2.right * pushForce);
            }
            else
            {
                rb.AddForce(-Vector2.right * pushForce);
            }

            rb.AddForce(Vector2.up * (pushForce / 2f) * (Random.value * 2 - 1));
        }


    }
}
