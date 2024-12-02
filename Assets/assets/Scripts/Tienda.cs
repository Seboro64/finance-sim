
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Tienda : MonoBehaviour
{
    public TextMeshProUGUI textoAcontado;
    public TextMeshProUGUI textoAPlazos;

    [SerializeField]public UnityEngine.UI.Image imagenObjeto;

    public Sprite[] objetos;

    public int[] precios;
    public int[] preciosPlazos;

    [SerializeField]private int objetoActual;

    void Update()
    {
        imagenObjeto.sprite = objetos[objetoActual];

        textoAcontado.text = "Precio a contado: " + precios[objetoActual];
        textoAPlazos.text = "Precio a plazos: " + preciosPlazos[objetoActual];

        Mathf.Clamp(objetoActual, 0, objetos.Length - 1);

    }

    public void Siguiente()
    {
        objetoActual++;
        if (objetoActual >= objetos.Length)
        {
            objetoActual = 0;
        }
    }

    public void Anterior()
    {
        objetoActual--;
        if (objetoActual < 0)
        {
            objetoActual = objetos.Length - 1;
        }
    }

    public void ComprarAContado()
    {
        if (GameManager.instance.monedasPerma >= precios[objetoActual])
        {
            LlevarACasa();
            GameManager.instance.PegarDeContado(precios[objetoActual]);
            objetos[objetoActual] = null;
            precios[objetoActual] = 0;
            preciosPlazos[objetoActual] = 0;
        }
    }

    public void ComprarAPlazos()
    {
        GameManager.instance.SumarDeuda(preciosPlazos[objetoActual]);

        LlevarACasa();
        objetos[objetoActual] = null;
        precios[objetoActual] = 0;
        preciosPlazos[objetoActual] = 0;
    }

    public void LlevarACasa()
    {
        switch (objetos[objetoActual].name)
        {
            case "CAMA":
                GameManager.instance.Cama = true;
                break;
            case "MESA":
                GameManager.instance.Mesa = true;
                break;
            case "LIBRERO":
                GameManager.instance.Librero = true;
                break;
            case "REFRI":
                GameManager.instance.Refri = true;
                break;
            case "TELE":
                GameManager.instance.Tele = true;
                break;
            case "PLANTA":
                GameManager.instance.Planta = true;
                break;
            case "FREG":
                GameManager.instance.Fregadero = true;
                break;
            case "CANDE":
                GameManager.instance.Candelabro = true;
                break;
        }
    }
}
