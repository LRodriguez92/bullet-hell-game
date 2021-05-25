using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    private float horizontal;
    private float vertical;

    public float runSpeed = 5f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Die();
        }
        else if (collision.gameObject.CompareTag("Goal"))
        {
            Win();
        }
    }

    private void Die()
    {
        Debug.Log("You Lose!");
    }

    private void Win()
    {
        Debug.Log("You Win!");
    }
}
