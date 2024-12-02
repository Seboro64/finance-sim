using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public void IrACasa()
    {
        SceneManager.LoadScene("Casa");
    }
    public void IrATienda()
    {
        SceneManager.LoadScene("Tienda");
    }
    public void IrAChambear()
    {
        SceneManager.LoadScene("CoinMining");
    }
}
