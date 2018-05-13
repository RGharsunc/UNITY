using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScale : MonoBehaviour {

	
    void OnMouseUp()
    {
        transform.localScale = new Vector3(transform.localScale.x / 2f,
                                            transform.localScale.y / 2f,
                                            transform.localScale.z / 2f);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        transform.localScale = new Vector3(transform.localScale.x * 2f,
                                            transform.localScale.y * 2f,
                                            transform.localScale.z * 2f);
    }
}
