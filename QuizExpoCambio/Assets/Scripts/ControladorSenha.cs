using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorSenha : MonoBehaviour
{
    public GameObject senha1, senha2, senha3, senha4, senha5, senha6, painelInformacoes;

    public bool informacoes;
    // Start is called before the first frame update
    void Start()
    {
       informacoes = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Senha1()
    {
        senha1.SetActive(false);
        senha2.SetActive(true);
        senha3.SetActive(false);
        senha4.SetActive(false);
        senha5.SetActive(false);
        senha6.SetActive(false);
    }
    public void Senha2()
    {
        senha1.SetActive(false);
        senha2.SetActive(false);
        senha3.SetActive(true);
        senha4.SetActive(false);
        senha5.SetActive(false);
        senha6.SetActive(false);
    }
    public void Senha3()
    {
        senha1.SetActive(false);
        senha2.SetActive(false);
        senha3.SetActive(false);
        senha4.SetActive(true);
        senha5.SetActive(false);
        senha6.SetActive(false);
    }
    public void Senha4()
    {
        senha1.SetActive(false);
        senha2.SetActive(false);
        senha3.SetActive(false);
        senha4.SetActive(false);
        senha5.SetActive(true);
        senha6.SetActive(false);
    }
    public void Senha5()
    {
        senha1.SetActive(false);
        senha2.SetActive(false);
        senha3.SetActive(false);
        senha4.SetActive(false);
        senha5.SetActive(false);
        senha6.SetActive(true);
    }
    public void Senha6()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void SenhaErrada()
    {
        senha1.SetActive(true);
        senha2.SetActive(false);
        senha3.SetActive(false);
        senha4.SetActive(false);
        senha5.SetActive(false);
        senha6.SetActive(false);
    }

    public void Informacoes()
    {
        painelInformacoes.SetActive(!informacoes);
    }

    public void SaibaMais()
    {
        SceneManager.LoadScene("SaibaMais");
    }
}
