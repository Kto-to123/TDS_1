using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject point;
    public GameObject enemy;
    public int nomber = 1;
    public GameObject enemy2;
    public int nomber2 = 1;
    public bool noRepeat = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            for (int i = 0; i < nomber; i++)
            {
                Instantiate(enemy, new Vector3(point.transform.position.x + (i * 2), point.transform.position.y, point.transform.position.z), transform.rotation);
            }

            if (enemy2 != null)
            {
                for (int i = 0; i < nomber2; i++)
                {
                    Instantiate(enemy2, new Vector3(point.transform.position.x + (i * 2), point.transform.position.y, point.transform.position.z + 2), transform.rotation);
                }
            }

            if (noRepeat)
            {
                Destroy(gameObject);
            }
        }
    }
}
