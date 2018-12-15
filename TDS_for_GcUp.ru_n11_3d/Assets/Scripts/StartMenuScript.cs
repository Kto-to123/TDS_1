using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour {

	public void LVL1Start()
    {
        SceneManager.LoadScene("1");
    }

    public void LVLTestStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
