using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioControlador : MonoBehaviour
{
    public GameObject painelInicio, painelRA, painelPremio, painelOpcao;
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
    public void AbrirPainelRA()
    {
        painelInicio.SetActive(false);
        painelRA.SetActive(true);
    }

    public void FecharPainelRA()
    {
        painelRA.SetActive(false);
        painelInicio.SetActive(true);

    }

    public void IniciarRecebaPremio()
    {
        painelInicio.SetActive(false);
        painelPremio.SetActive(true);
    }

     public void FecharRecebaPremio()
    {
        painelPremio.SetActive(false);
        painelInicio.SetActive(true);
    }

    public void IniciarHome()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void AbrirPainelOpcao()
    {
        painelOpcao.SetActive(true);
    }
    public void FecharPainelOpcao()
    {
        painelOpcao.SetActive(false);
    }
    public void FecharAPP()
    {
        Application.Quit();
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
