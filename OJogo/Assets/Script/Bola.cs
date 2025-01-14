using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float VeloBola;
    public float DesvioBolaX;
    public float DesvioBolaY;

    public Rigidbody2D oRigidbody2D;
    public AudioSource somBola;

    void Start()
    {
        MoveBola();
    }

    void Update()
    {

    }

    private void MoveBola()
    {
        oRigidbody2D.velocity = new Vector2(VeloBola, VeloBola);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        somBola.Play();
        oRigidbody2D.velocity += new Vector2(DesvioBolaX, DesvioBolaY);
    }
}
