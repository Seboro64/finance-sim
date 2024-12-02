using UnityEngine;

public class MoneyBag : MonoBehaviour
{
    [Range(0,20)]
    [SerializeField] private float moveSpeed; // Velocidad de movimiento del saco de dinero

    [SerializeField] private float movementRange; // Rango de movimiento limitado por un clamp

    [Range(-10, 10)]
    [SerializeField] private float alturaDeLaBolsa; // Altura de la bolsa de dinero

    void Update()
    {
        MoveMoneyBag();
    }

    void MoveMoneyBag()
    {
        float move = Input.GetAxisRaw("Horizontal");

        float moveAmount = move * moveSpeed * Time.deltaTime;

        Vector2 newPosition = moveAmount * Vector2.right;


        // Limitar el movimiento dentro del área coloreada
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -movementRange, movementRange),alturaDeLaBolsa);

        transform.Translate(newPosition);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            //FindObjectOfType<CoinSpawner>().IncreaseCoinCount();
        }
    }
}
