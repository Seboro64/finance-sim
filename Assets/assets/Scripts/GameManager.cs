using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    private static GameManager instance;


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

    public void Deuda()
    {
        //deuda = monedasPerma * 2;
    }

}
