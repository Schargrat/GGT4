using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boccia : MonoBehaviour {
    public Renderer rend;
    public Color altColor = Color.red;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3((float)4.09, (float)2.3, (float)0.28);
        sphere.transform.localScale = new Vector3((float)0.3, (float)0.3, (float)0.3);
        rend.material.color = altColor;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
