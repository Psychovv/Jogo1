using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadePlayer;
    public bool Player1;
    public float yMin;
    public float yMax;

    void Start()
    {

    }

    void Update()
    {
        LimitaPlayer();

        if (Player1 == true)
        {
            GoPlayer1();
        }
        else
        {
            GoPlayer2();
        }
    }

    private void GoPlayer1()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidadePlayer * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadePlayer * Time.deltaTime);
        }
    }

    private void GoPlayer2()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * velocidadePlayer * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidadePlayer * Time.deltaTime);
        }
    }
    private void LimitaPlayer()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));
    }
}
