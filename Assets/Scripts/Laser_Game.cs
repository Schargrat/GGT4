using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Game : MonoBehaviour {
    private bool istrigger = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (istrigger == true)
        {
            StartCoroutine(Waitforlaser());
        }
	}
    IEnumerator Waitforlaser()
    {
        yield return new WaitForSeconds(3);
        GameObject.Destroy(this.gameObject);
    }
}
