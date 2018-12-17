using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingScript : MonoBehaviour {

    public float speed = 3.0f;
    public float shootingRange = 10.0f;
    Transform player;
    public GameObject bullet;
    public GameObject point1;
    public GameObject point2;

    bool weaponsRepiad = true;

    void Start ()
    {
		
	}
	

	void Update ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist < shootingRange && weaponsRepiad)
        {
            Instantiate(bullet, new Vector3(point1.transform.position.x, point1.transform.position.y, point1.transform.position.z), transform.rotation);
            Instantiate(bullet, new Vector3(point2.transform.position.x, point2.transform.position.y, point2.transform.position.z), transform.rotation);
            //Debug.Log(dist);
            weaponsRepiad = false;
            StartCoroutine("Repied");
        }
        //else if (weaponsRepiad)
        //{
        //    Debug.Log(dist);
        //}
        //else
        //{
        //    Debug.Log(weaponsRepiad);
        //}
    }

    IEnumerator Repied()
    {
        yield return new WaitForSeconds(0.2f);
        weaponsRepiad = true;
    }
}
