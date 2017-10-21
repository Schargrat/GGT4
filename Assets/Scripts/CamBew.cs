using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamBew : MonoBehaviour {

    void Start()
    {

    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Mouse X");
        float y = -Input.GetAxis("Mouse Y");
        Camera.main.transform.Rotate(x, y, 0);

    }
}
