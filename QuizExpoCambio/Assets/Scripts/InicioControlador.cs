using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioControlador : MonoBehaviour
{
    // Start is called before the first frame update
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

    public void IniciarRA()
    {
        SceneManager.LoadScene("GameBoyColor");
    }

    public void IniciarRecebaPremio()
    {
        SceneManager.LoadScene("RecebePremio");
    }

    public void IniciarHome()
    {
        SceneManager.LoadScene("Inicio");
    }
}
