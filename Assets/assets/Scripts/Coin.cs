using UnityEngine;

public class Coin : MonoBehaviour
{
    public float fallSpeed = 5.0f; // Velocidad de caída de las monedas

    void Update()
    {
        Fall();
    }

    void Fall()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

        // Destruir la moneda si cae fuera de la pantalla
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MoneyBag"))
        {
            Destroy(gameObject);
            FindObjectOfType<CoinSpawner>().IncreaseCoinCount();
        }
    }
}
