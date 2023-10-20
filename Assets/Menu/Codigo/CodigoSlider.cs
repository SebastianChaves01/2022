using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoSlider : MonoBehaviour
{
    public float SumaClick;    
    public GameObject camara;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //camara.transform.position += Vector3.up* Time.deltaTime;
        if (Input.GetMouseButtonDown(1))
        {
            slider.value+= 0.1f;
            print(slider.value ); 
        }

        if (Input.GetMouseButtonDown(0))
        {

            slider.value -= 0.1f;
            print(slider.value);
        }
        


        


    }
}
