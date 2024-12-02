using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{

    private UnityEngine.UI.Image imagenfondo;

    public Sprite[] fondos;

    private void Awake()
    {
        imagenfondo = GetComponent<UnityEngine.UI.Image>();
    }
    void Update()
    {

        switch (GameManager.instance.hora)
        {
            case 0:
                imagenfondo.sprite = fondos[0];
                break;
            case 1:
                imagenfondo.sprite = fondos[1];
                break;
            case 2:
                imagenfondo.sprite = fondos[2];
                break;
        }
    }
}
