using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CasaManager : MonoBehaviour
{
    public Light luz;
    public GameObject[] muebles;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    private void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameManager.instance.hora)
        {
            case 0:
               // textoHora.text = "Mañana";
               luz.color = new Color(0.99f, 1, 0.91f, 1);
               luz.gameObject.transform.rotation = Quaternion.Euler(90, 0, 0);
                break;
            case 1:
                // textoHora.text = "Tarde";
                luz.color = new Color(1, 0.83f, 0.48f, 1);

                luz.gameObject.transform.rotation = Quaternion.Euler(90, 0, 0);

                break;
            case 2:
                luz.gameObject.transform.rotation = Quaternion.Euler(90, 0, 0);

                // textoHora.text = "Noche";
                luz.color = new Color(0.16f, 0, 0.52f, 1);

                break;
        }


        muebles[0].SetActive(GameManager.instance.Cama);
        muebles[1].SetActive(GameManager.instance.Mesa);
        muebles[2].SetActive(GameManager.instance.Librero);
        muebles[3].SetActive(GameManager.instance.Refri);
        muebles[4].SetActive(GameManager.instance.Tele);
        muebles[5].SetActive(GameManager.instance.Planta);
        muebles[6].SetActive(GameManager.instance.Fregadero);
        muebles[7].SetActive(GameManager.instance.Candelabro);
        
    }

   
	
}
