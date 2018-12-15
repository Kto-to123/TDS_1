using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour {

    private void OnMouseDown()
    {
        SceneManager.LoadScene("1");
        Debug.Log("Klick");
    }
}
