using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float initVelocity = 4f;

    Rigidbody2D ballRb2D;

    float multiplyVelocity = 1.1f;

    private void Awake() => ballRb2D = GetComponent<Rigidbody2D>();

    private void Start()
    {
        Launch();
    }
    void Launch()
    {
        float xVelocity = Random.Range(0,2) == 0 ? -1 : 1;
        float yVelocity = Random.Range(0,2) == 0 ? -1 : 1;

        ballRb2D.velocity = new Vector2(xVelocity, yVelocity) * initVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            ballRb2D.velocity *= multiplyVelocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Goal1"))
        {
            GameManager.Instance.Player2Score();
            GameManager.Instance.Restar();
            Launch();
        }
        else
        {
            GameManager.Instance.Player1Score();
            GameManager.Instance.Restar();
            Launch();
        }
    }
}
