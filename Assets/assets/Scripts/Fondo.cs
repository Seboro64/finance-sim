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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
