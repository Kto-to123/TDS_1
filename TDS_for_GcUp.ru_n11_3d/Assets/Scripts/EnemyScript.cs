using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour {

    public int HP = 100;

    NavMeshAgent nav;
    Transform player;
    GameObject UI;
    UIScript uiScript;


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        UI = GameObject.FindGameObjectWithTag("UI");
        uiScript = UI.GetComponent<UIScript>();
        //playerHealth = player.GetComponent<PlayerHealth>();
        //enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }
	
	void Update () {
        nav.SetDestination(player.position);
        if (HP <= 0)
        {
            uiScript.KillEnemy();
            Destroy(this.gameObject);
        } 
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            HP -= 20;
        }
    }
}
