using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioControlador : MonoBehaviour
{
    public GameObject Painel, Painel2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IniciarQuiz()
    {
        SceneManager.LoadScene("Quiz");
    }

    public void VoltaMenu()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void AbrirPainel()
    {
        Painel.SetActive(true);
    }

    public void FecharPainel()
    {
        Painel.SetActive(false);
    }

    public void AbrirPainel2()
    {
        Painel2.SetActive(true);
    }

    public void FecharPainel2()
    {
        Painel2.SetActive(false);
    }

    public void IniciarRecebaPremio()
    {
        SceneManager.LoadScene("RecebePremio");
    }

    public void IniciarHome()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void Atari()
    {
        SceneManager.LoadScene("Atari");
    }

    public void GameBoy()
    {
        SceneManager.LoadScene("GameBoyColor");
    }

    public void MegaDriver()
    {
        SceneManager.LoadScene("MegaDriver");
    }

    public void Nintendo()
    {
        SceneManager.LoadScene("Nintendo");
    }
}
