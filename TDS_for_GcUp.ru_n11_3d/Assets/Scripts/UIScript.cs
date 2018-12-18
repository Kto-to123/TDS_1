using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public bool activMenu = false;
    public GameObject menu;
    public Text KilsText;
    public Text HilthText;
    public Text Magazin;

    GameObject player;
    PlayerHealth PlayerHealth;
    public int kils = 0;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        PlayerHealth = player.GetComponent<PlayerHealth>();
    }

    public void KillEnemy()
    {
        kils++;
        KilsText.text = kils.ToString();
        RoomManager.Inst.XP += 200;
        RoomManager.Inst.OllKills += 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            activMenu = !activMenu;
            menu.SetActive(activMenu);
        }
        if (PlayerHealth.currentHealth >= 0)
        {
            HilthText.text = PlayerHealth.currentHealth.ToString();
        }
        else
        {
            HilthText.text = "0";
        }
    }

    public void MainMenuStart()
    {
        //Debug.Log("OK");
        SceneManager.LoadScene("StartScene");
    }

    public void ActiveMenu()
    {
        menu.SetActive(true);
    }

    public void MagazineSet(int mag)
    {
        Magazin.text = mag.ToString();
    }
}
