using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoScrollBar : MonoBehaviour
{
    public GameObject carrito;
    public Scrollbar scrollbar;
    // Start is called before the first frame update
    void Start()
    {
        scrollbar = GetComponent<Scrollbar>();
    }

    // Update is called once per frame
    void Update() { 
    
        carrito.transform.localScale= new Vector3(scrollbar.value, scrollbar.value, 0);
    }
}
