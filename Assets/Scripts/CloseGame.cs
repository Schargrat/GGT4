using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseGame : MonoBehaviour {

        public void doquit()
    {
        Debug.Log("has quit the game");
        Application.Quit();
    }
    }
