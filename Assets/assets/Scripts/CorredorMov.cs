using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorredorMov : MonoBehaviour
{
    public float sinCenterX;
    [SerializeField] public float speed;

    private void FixedUpdate()
    {
        Vector2 pos= transform.position;
        float sin = Mathf.Sin(pos.y);
        pos.x = sinCenterX + sin;
        pos.y -= speed * Time.fixedDeltaTime;
        transform.position = pos;

        if (pos.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
