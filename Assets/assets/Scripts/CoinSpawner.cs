using UnityEngine;
using UnityEngine.UI;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab; // El prefab de la moneda

    private float ultimoCambio;
    private float tiempoDRecarga; //Consejo de uche
    [SerializeField] public float coolDown;


    private void Update()
    {
        if (ultimoCambio < Time.time)
        {
            ultimoCambio = Time.time + coolDown;
            tiempoDRecarga = 0;
            GameObject coin = Instantiate(coinPrefab, transform.position, Quaternion.identity);
            coin.transform.SetParent(transform);
            float x = Random.Range(-3, 3);
            coin.GetComponent<CorredorMov>().sinCenterX = x;
            float vel = Random.Range(5, 10);
            coin.GetComponent<CorredorMov>().speed = vel;
        }

        tiempoDRecarga += Time.deltaTime;
        tiempoDRecarga = Mathf.Clamp(tiempoDRecarga, 0, coolDown);
    }
}

