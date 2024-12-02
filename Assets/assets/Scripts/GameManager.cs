using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    public static GameManager instance;

    public int monedasPerma = 0;

    public int deuda;

    public int dia;

    public int hora;

    public bool Cama;
    public bool Mesa;
    public bool Librero;
    public bool Refri;
    public bool Tele;
    public bool Planta;
    public bool Fregadero;
    public bool Candelabro;


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

    private void Update()
    {
        if (hora>3)
        {
            AumentarDia();
            hora = 0;
        }
    }

    public void AumentarDia()
    {
        dia++;
    }

    public void AumentarHora()
    {
        hora++;
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
    public void PegarDeContado(int apagar)
    {
        if (monedasPerma<apagar)
        {
            return;
        }
        else
        {
            monedasPerma = monedasPerma - apagar;
        }
    }
}
