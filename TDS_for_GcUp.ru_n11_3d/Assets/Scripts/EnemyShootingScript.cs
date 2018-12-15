using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingScript : MonoBehaviour {

    public float speed = 3.0f;
    public float shootingRange = 5.0f;
    public GameObject player;
    public GameObject bullet;
    public GameObject point;

	void Start ()
    {
		
	}
	

	void Update ()
    {
        //Ray ray = new Ray(transform.position, player.transform.position);
        //RaycastHit hit;

        //if(Physics.SphereCast(ray, 0.75f, out hit))
        //{
        //    if (hit.distance < shootingRange)
        //    {
        //        Instantiate(bullet, new Vector3(point.transform.position.x, point.transform.position.y, point.transform.position.z), transform.rotation);
        //    }
        //}

        //float dist = Vector3.Distance(player.transform.position, transform.position);
        if (Vector3.Distance(player.transform.position, transform.position) < 3)
        {
            Instantiate(bullet, new Vector3(point.transform.position.x, point.transform.position.y, point.transform.position.z), transform.rotation);
        }
    }
}
