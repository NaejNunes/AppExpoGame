using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlador : MonoBehaviour
{
    public TempoControlador scriptTempo;
    private int contadorPergunta;
    public string NomeFase;
    public int pontos, pontosAntigos;
    public Text txtPontos;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtPontos.text = pontos.ToString();


        if (scriptTempo.segundos <= 0)
        {
            contadorPergunta += 1;
            SceneManager.LoadScene(NomeFase);
        }
    }

    public void RespostaCorreta()
    {
        pontos += 1;       
        contadorPergunta += 1;
        SceneManager.LoadScene(NomeFase);
        Debug.Log(pontos);
    }

    public void RespostaErrada()
    {
        contadorPergunta += 1;
        SceneManager.LoadScene(NomeFase);
        Debug.Log(pontos);
    }

    public void GuardarPontos()
    {
       // PontosFinaisTXT.text = Pontuacao.Pontos.ToString();
    }

    public void AtualziarPontos()
    {

    }
}
