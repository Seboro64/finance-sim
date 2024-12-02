using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AgarrarMonedas : MonoBehaviour
{
    public CoinMiningManager gameManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.GetComponent<CorredorMov>())
        {
            Destroy(other.gameObject);
            gameManager.monedas++;
        }
    }
}
