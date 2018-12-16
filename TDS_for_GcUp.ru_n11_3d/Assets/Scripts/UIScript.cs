using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Text KilsText;

    int kils = 0;

	public void KillEnemy()
    {
        kils++;
        KilsText.text = kils.ToString();
        RoomManager.Inst.XP += 200;
        RoomManager.Inst.OllKills += 1;
    }
}
