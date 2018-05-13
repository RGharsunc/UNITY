using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public GameObject gameObject;
    public float range = 5f, moveSpeed = 30f, turnSpeed = 1500f;

    void Start()
    {

    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);
        }


    }

    
}
