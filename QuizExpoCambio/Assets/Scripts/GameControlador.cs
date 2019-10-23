using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControlador : MonoBehaviour
{
    public TempoControlador scriptTempo;
    public GameObject[] perguntas;
    private int pontos, contadorPergunta;
    public Text descricaoPontosTxt, pontosTxt;
    public AudioClip somCorreto, somErrado;


    // Start is called before the first frame update
    void Start()
    {
        contadorPergunta = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //TROCA DE FASE CASO O TEMPO ACABE
        if (scriptTempo.segundos < 0)
        {
            TrocaPerguntas();
            scriptTempo.segundos = 30;
        }    
    }

    //MÉTODO QUE ATRIBUIMOS AO BOTÃO COM A RESPOSTA CORRETA
    public void RespostaCorreta()
    {
        AudioSource.PlayClipAtPoint(somCorreto, Camera.main.transform.position * Time.deltaTime);
        pontos += 1;
        TrocaPerguntas();
    }

    //MÉTODO QUE ATRIBUIMOS AO BOTÃO COM A RESPOSTA ERRADA
    public void RespostaErrada()
    {
        AudioSource.PlayClipAtPoint(somErrado, Camera.main.transform.position * Time.deltaTime);
        TrocaPerguntas();
    }

    //FINALIZA O JOGO QUANDO AS PERGUNTAS ACABAREM
    public void FimDeFase()
    {
        if (pontos < 3)
        {
            descricaoPontosTxt.text = "Você foi um gerreiro, mesmo não sabendo muita coisa chegou até o final. \n Parabéns!";
            pontosTxt.text = "" + pontos;
        }
        else if (pontos > 3 && pontos < 8)
        {
            descricaoPontosTxt.text = "Olha só você tem futuro. \n Parabéns!";
            pontosTxt.text = "" + pontos;
        }
        else if (pontos > 7 && pontos < 10)
        {
            descricaoPontosTxt.text = "Opa! O que é isso? temos um Mestre na arte! \n Parabéns! VOCÊ É DE MAIS!!!";
            pontosTxt.text = "" + pontos;
        }
        else if (pontos == 10)
        {
            descricaoPontosTxt.text = "Ó senhor dos NERDS, me deixe ser seu discípulo!!!";
            pontosTxt.text = "" + pontos;
        }
    }
    //MÉTODO QUE TROCA AS PERGUNTAS
    public void TrocaPerguntas()
    {
        contadorPergunta++;

        switch (contadorPergunta)
        {
            case 1:
                perguntas[0].SetActive(true);
                perguntas[1].SetActive(false);
                perguntas[2].SetActive(false);
                perguntas[3].SetActive(false);
                perguntas[4].SetActive(false);
                perguntas[5].SetActive(false);
                perguntas[6].SetActive(false);
                perguntas[7].SetActive(false);
                perguntas[8].SetActive(false);
                perguntas[9].SetActive(false);
                break;

            case 2:
                perguntas[0].SetActive(false);
                perguntas[1].SetActive(true);
                perguntas[2].SetActive(false);
                perguntas[3].SetActive(false);
                perguntas[4].SetActive(false);
                perguntas[5].SetActive(false);
                perguntas[6].SetActive(false);
                perguntas[7].SetActive(false);
                perguntas[8].SetActive(false);
                perguntas[9].SetActive(false);
                break;

            case 3:
                perguntas[0].SetActive(false);
                perguntas[1].SetActive(false);
                perguntas[2].SetActive(true);
                perguntas[3].SetActive(false);
                perguntas[4].SetActive(false);
                perguntas[5].SetActive(false);
                perguntas[6].SetActive(false);
                perguntas[7].SetActive(false);
                perguntas[8].SetActive(false);
                perguntas[9].SetActive(false);
                break;

            case 4:
                perguntas[0].SetActive(false);
                perguntas[1].SetActive(false);
                perguntas[2].SetActive(false);
                perguntas[3].SetActive(true);
                perguntas[4].SetActive(false);
                perguntas[5].SetActive(false);
                perguntas[6].SetActive(false);
                perguntas[7].SetActive(false);
                perguntas[8].SetActive(false);
                perguntas[9].SetActive(false);
                break;

            case 5:
                perguntas[0].SetActive(false);
                perguntas[1].SetActive(false);
                perguntas[2].SetActive(false);
                perguntas[3].SetActive(false);
                perguntas[4].SetActive(true);
                perguntas[5].SetActive(false);
                perguntas[6].SetActive(false);
                perguntas[7].SetActive(false);
                perguntas[8].SetActive(false);
                perguntas[9].SetActive(false);
                break;

            case 6:
                perguntas[0].SetActive(false);
                perguntas[1].SetActive(false);
                perguntas[2].SetActive(false);
                perguntas[3].SetActive(false);
                perguntas[4].SetActive(false);
                perguntas[5].SetActive(true);
                perguntas[6].SetActive(false);
                perguntas[7].SetActive(false);
                perguntas[8].SetActive(false);
                perguntas[9].SetActive(false);
                break;

            case 7:
                perguntas[0].SetActive(false);
                perguntas[1].SetActive(false);
                perguntas[2].SetActive(false);
                perguntas[3].SetActive(false);
                perguntas[4].SetActive(false);
                perguntas[5].SetActive(false);
                perguntas[6].SetActive(true);
                perguntas[7].SetActive(false);
                perguntas[8].SetActive(false);
                perguntas[9].SetActive(false);
                break;

            case 8:
                perguntas[0].SetActive(false);
                perguntas[1].SetActive(false);
                perguntas[2].SetActive(false);
                perguntas[3].SetActive(false);
                perguntas[4].SetActive(false);
                perguntas[5].SetActive(false);
                perguntas[6].SetActive(false);
                perguntas[7].SetActive(true);
                perguntas[8].SetActive(false);
                perguntas[9].SetActive(false);
                break;

            case 9:
                perguntas[0].SetActive(false);
                perguntas[1].SetActive(false);
                perguntas[2].SetActive(false);
                perguntas[3].SetActive(false);
                perguntas[4].SetActive(false);
                perguntas[5].SetActive(false);
                perguntas[6].SetActive(false);
                perguntas[7].SetActive(false);
                perguntas[8].SetActive(true);
                perguntas[9].SetActive(false);
                break;

            case 10:
                perguntas[0].SetActive(false);
                perguntas[1].SetActive(false);
                perguntas[2].SetActive(false);
                perguntas[3].SetActive(false);
                perguntas[4].SetActive(false);
                perguntas[5].SetActive(false);
                perguntas[6].SetActive(false);
                perguntas[7].SetActive(false);
                perguntas[8].SetActive(false);
                perguntas[9].SetActive(true);
                break;

            case 11:
                perguntas[0].SetActive(false);
                perguntas[1].SetActive(false);
                perguntas[2].SetActive(false);
                perguntas[3].SetActive(false);
                perguntas[4].SetActive(false);
                perguntas[5].SetActive(false);
                perguntas[6].SetActive(false);
                perguntas[7].SetActive(false);
                perguntas[8].SetActive(false);
                perguntas[9].SetActive(false);

                perguntas[10].SetActive(true);
                FimDeFase();
                Time.timeScale = 0;

                break;
        }
    }

}
