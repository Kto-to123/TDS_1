using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLVLScript : MonoBehaviour {

    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Klick");
    }
}
