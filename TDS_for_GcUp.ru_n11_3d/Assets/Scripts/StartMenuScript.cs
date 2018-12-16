using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuScript : MonoBehaviour {

    public GameObject ShopMenu;
    public GameObject MainMenu;
    public Text kills;
    public Text XP;


    private void Start()
    {
        kills.text = "Kills: " + RoomManager.Inst.OllKills.ToString();
        XP.text = "XP: " + RoomManager.Inst.XP.ToString();
    }


    public void LVL1Start()
    {
        SceneManager.LoadScene("1");
    }

    public void LVLTestStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShopOpen()
    {
        ShopMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void MainMenuOpen()
    {
        ShopMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void Take1weapon()
    {
        RoomManager.Inst.Weapon = 1;
    }

    public void Take2weapon()
    {
        RoomManager.Inst.Weapon = 2;
    }

    public void Take3weapon()
    {
        RoomManager.Inst.Weapon = 3;
    }
}
