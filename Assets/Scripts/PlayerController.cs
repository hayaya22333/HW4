using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    private float flapForce = 4f;
    public bool gameOver = false;
    public int points = 0;
    public delegate void EmptyDelegate();
    public delegate void IntDelegate(int x);
    public event IntDelegate PointEarned;
    public event EmptyDelegate GameOver;
    public event EmptyDelegate PlayerFlapped;
    void Update()
    {
        if (Input.GetKeyDown("space") && !gameOver)
        {
            PlayerFlapped.Invoke();
            rb.velocity = new Vector2(rb.velocity.x, flapForce);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Tube")
        {
            GameOver.Invoke();
            gameOver = true;
        }
        else if (other.tag == "PointGate")
        {
            points += 1;
            PointEarned.Invoke(points);
        }
    }
}
