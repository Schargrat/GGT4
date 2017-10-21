using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {

    public Camera Camerak;
    private Camera camerat;

    public Camera Camerat { get => camerat; set => camerat = value; }

    // Use this for initialization
    void Start () {
        if (Camerak.enabled == true)
        {
            Camerak = false;
            Camerat = true;
        } else
        {
            Camerak = true;
            Camerat = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
