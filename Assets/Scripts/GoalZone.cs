using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalZone : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI text;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            score++;
            collision.collider.transform.position = Vector3.zero;

            collision.collider.GetComponent<BallBehavior>().Serve();
            text.text = "" + score;
        }
    }
}
