using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour {

    public int HP = 100;

    int weaponsDamage;
    NavMeshAgent nav;
    Transform player;
    GameObject UI;
    UIScript uiScript;
    public GameObject mi;


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        UI = GameObject.FindGameObjectWithTag("UI");
        uiScript = UI.GetComponent<UIScript>();
        //playerHealth = player.GetComponent<PlayerHealth>();
        //enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();

        if (RoomManager.Inst.Weapon == 1)
        {
            weaponsDamage = 60;
        }
        else if (RoomManager.Inst.Weapon == 3)
        {
            weaponsDamage = 101;
        }
        else
        {
            weaponsDamage = 100;
        }
    }
	
	void Update () {
        nav.SetDestination(player.position);
        if (HP <= 0)
            Death();
	}

    void Death()
    {
        uiScript.KillEnemy();
        Destroy(mi);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            HP -= 20;
        }

        if (other.tag == "Weapons")
        {
            HP -= weaponsDamage;
            if (weaponsDamage > 100)
                Death();
        }
    }
}
