using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool GolPlayer1;

    //deletar o metodo start e upate

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GolPlayer1 == true)
        {
            FindObjectOfType<GameManager>().AddPontoPlayer2();
            other.gameObject.transform.position = Vector2.zero;
        }
        else
        {
            FindObjectOfType<GameManager>().AddPontoPlayer1();
            other.gameObject.transform.position = Vector2.zero;
        }
    }
}
