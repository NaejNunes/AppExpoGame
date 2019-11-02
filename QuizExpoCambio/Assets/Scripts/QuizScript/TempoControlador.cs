using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoControlador : MonoBehaviour
{
    public float segundos;

    // Start is called before the first frame update
    void Start()
    {
       segundos = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(segundos);
        segundos -= Time.deltaTime;

        var sliderTempo = transform.GetChild(0).GetComponentInChildren<Slider>();
        sliderTempo.value = segundos;
    }
}
