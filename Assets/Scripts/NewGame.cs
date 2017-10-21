using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickExample : MonoBehaviour
{
    public void loadmain()
    {
        SceneManager.LoadScene("mainscene", LoadSceneMode.Additive);
    }

}
