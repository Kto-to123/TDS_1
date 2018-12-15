using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting2 : MonoBehaviour {

    public GameObject Bullet;
    public GameObject Point;


	void Start () {
		
	}
	

	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            for (float i = -0.03f; i < 0.03f; i += 0.01f)
            {
                Quaternion Qua1 = new Quaternion(transform.rotation.x, transform.rotation.y + i, transform.rotation.z, transform.rotation.w);
                Instantiate(Bullet, new Vector3(Point.transform.position.x, Point.transform.position.y, Point.transform.position.z), Qua1);
            }


            //Instantiate(Bullet, new Vector3(Point.transform.position.x, Point.transform.position.y, Point.transform.position.z), transform.rotation);
        }
    }
}
