using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int PontoPlayer1;
    public int PontoPlayer2;

    public Text textoPontuacao;
    public AudioSource somGol;

    public bool Pause;

    void Start()
    {
        Cursor.visible = false;
        Time.timeScale = 0f;
        Pause = true;

        PontoPlayer1 = 0;
        PontoPlayer2 = 0;
        textoPontuacao.text = PontoPlayer1 + " X " + PontoPlayer2;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReiniciarPartida();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FecharJogo();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pausar();
        }
    }

    public void AddPontoPlayer1()
    {
        PontoPlayer1 += 1;
        AtualizaTextoPontuacao();
    }

    public void AddPontoPlayer2()
    {
        PontoPlayer2 += 1;
        AtualizaTextoPontuacao();
    }

    public void AtualizaTextoPontuacao()
    {
        textoPontuacao.text = PontoPlayer1 + " X " + PontoPlayer2;
        somGol.Play();
    }

    private void ReiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void FecharJogo()
    {
        Application.Quit();
        Debug.Log("Fechando Jogo");
    }
    private void Pausar()
    {
        if (Pause == false)
        {
            Time.timeScale = 0f;
            textoPontuacao.text = "Pong for two" +
                                  "\n[Esc] Quit Game" +
                                  "\n[R] Reset Game" +
                                  "\n[Espace] Start and Pause Game";
            Pause = true;
        }
        else
        {
            Time.timeScale = 1f;
            Pause = false;
        }
    }
}
