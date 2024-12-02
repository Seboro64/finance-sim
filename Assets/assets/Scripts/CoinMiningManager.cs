using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinMiningManager : MonoBehaviour
{
    public int monedas = 0;
    public float tiempo = 0;
    public TextMeshProUGUI textoMonedas;
    public TextMeshProUGUI textoTiempo;


    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        tiempo -= Time.deltaTime;

        textoMonedas.text = monedas.ToString();
        textoTiempo.text = tiempo.ToString();

        if (tiempo <= 0)
        {
            Time.timeScale = 0;

            GameManager.instance.AumentarMonedas(monedas);
        }
        else 
        {
            Time.timeScale = 1;
        }
    }
}
