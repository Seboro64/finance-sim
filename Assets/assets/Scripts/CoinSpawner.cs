using UnityEngine;
using UnityEngine.UI;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab; // El prefab de la moneda
    public float coinSpawnRate = 1.0f; // Velocidad de aparición de las monedas
    public float timerLimit = 15.0f; // Límite de tiempo en segundos
    public Text coinCounterText; // Texto para mostrar la cantidad de monedas recolectadas
    public Text timerText; // Texto para mostrar el tiempo restante

    private int coinCount = 0;
    private float timer;

    void Start()
    {
        timer = timerLimit;
        InvokeRepeating("SpawnCoin", 1.0f, coinSpawnRate); // Generar monedas a intervalos definidos por coinSpawnRate
    }

    void Update()
    {
        UpdateTimer();
    }

    void SpawnCoin()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-7.5f, 7.5f), 6.0f, 0); // Posición de aparición de las monedas
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }

    void UpdateTimer()
    {
        timer -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Ceil(timer).ToString();

        if (timer <= 0)
        {
            CancelInvoke("SpawnCoin");
            timerText.text = "Time: 0";
            // Aquí puedes agregar lógica para finalizar el juego
        }
    }

    public void IncreaseCoinCount()
    {
        coinCount++;
        coinCounterText.text = "Coins: " + coinCount.ToString();
    }
}

