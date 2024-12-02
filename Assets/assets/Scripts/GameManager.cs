using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    public static GameManager instance;

    public int monedasPerma = 0;

    public int deuda;



    private void Awake()
    {
        if (instance == null)
        {
            GameManager.instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void AumentarDeuda()
    {
        deuda = deuda + (deuda / 3);
    }

    public void AumentarMonedas(int suma)
    {
        monedasPerma =+ suma;
    }

    public void SumarDeuda(int suma)
    {
        deuda += suma;
    }

    public void PegarDeuda()
    {
        deuda = deuda - monedasPerma;
        monedasPerma = 0;
        if (deuda<0)
        {
            monedasPerma = -deuda;
        }
    }
}
