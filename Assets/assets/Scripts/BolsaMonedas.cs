using UnityEngine;

public class MoneyBag : MonoBehaviour
{
    public float moveSpeed = 10.0f; // Velocidad de movimiento del saco de dinero
    public float movementRange = 7.5f; // Rango de movimiento limitado por la hitbox
    private Rigidbody2D rb;
    private bool isAwake = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic; // Configurar como Kinematic

        // Establecer la posición inicial en el centro de la pantalla en X
        rb.position = new Vector2(0, rb.position.y);
    }

    void Update()
    {
        if (isAwake)
        {
            MoveMoneyBag();
        }
        else
        {
            CheckForInput();
        }
    }

    void MoveMoneyBag()
    {
        float move = 0f;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move = -moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            move = moveSpeed * Time.deltaTime;
        }

        Vector2 newPosition = rb.position + new Vector2(move, 0);

        // Limitar el movimiento dentro del área coloreada
        newPosition.x = Mathf.Clamp(newPosition.x, -movementRange, movementRange);
        rb.MovePosition(newPosition);
    }

    void CheckForInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            isAwake = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            FindObjectOfType<CoinSpawner>().IncreaseCoinCount();
        }
    }
}
