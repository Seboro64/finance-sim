using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public TextMeshProUGUI textoMonedas = null;
    public TextMeshProUGUI textoHora = null;
    public TextMeshProUGUI textoDeudas = null;

    private void Update()
    {
        if (textoMonedas != null)
        {
            textoMonedas.text = GameManager.instance.monedasPerma.ToString();
            textoDeudas.text = GameManager.instance.deuda.ToString();

            switch (GameManager.instance.hora)
            {
                case 0:
                    textoHora.text = "Mañana";
                    break;
                case 1:
                    textoHora.text = "Tarde";
                    break;
                case 2:
                    textoHora.text = "Noche";
                    break;
            }
        }

    }

    public void IrACasa()
    {
        GameManager.instance.hora++;

        SceneManager.LoadScene("Casa");
    }
    public void IrATienda()
    {
        GameManager.instance.hora++;

        SceneManager.LoadScene("Tienda");
    }
    public void IrAChambear()
    {
        GameManager.instance.hora++;

        SceneManager.LoadScene("CoinMining");
    }
}
