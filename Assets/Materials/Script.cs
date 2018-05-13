using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Script : MonoBehaviour {
    
    public Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled; 
        }
    }
   
}
