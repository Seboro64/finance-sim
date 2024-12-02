using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBController : MonoBehaviour
{
    [Header("Movimento")]
    [SerializeField] private float velocidad;

    [Header("Limites")]
    public float limitesz;
    public float limitesx;

    void Update()
    {
        MovJoycon();
        Limites();
    }
    private void MovJoycon()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime * Input.GetAxisRaw("Horizontal"));
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime * Input.GetAxisRaw("Vertical"));
    }
    public void Limites()
    {
        Vector3 Posicion = transform.position;
        Posicion.z = Mathf.Clamp(Posicion.z, -limitesz, limitesz);
        Posicion.x = Mathf.Clamp(Posicion.x, -limitesx, limitesx);
        transform.position = Posicion;
    }
}
