using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserWand : MonoBehaviour {
    public int gamelive = 3;
    public int enemylive = 3;
    public bool game = true;
    // Use this for initialization
    void Start() {
        StartCoroutine(trydodge());
    }

    // Update is called once per frame
    void Update() {
        if (gamelive <= 0)
        {
            Debug.Log("player tod");
        }
        if (enemylive <= 0)
        {
            Debug.Log("gegner tod");
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "laser")
        {
            gamelive--;
            Debug.Log("aua");
        }
    }
    IEnumerator trydodge()
    {
        yield return new WaitForSeconds(3);
        if (Random.value > 0.6)
        {
            enemylive--;
        }

    }
}
