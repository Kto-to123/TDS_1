using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyScript : MonoBehaviour {

    public float speed = 1.5f;
    public float liveTime = 1f;

    private Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);

        Destroy(this.gameObject, liveTime);
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player" || collision.tag == "Scenery")
        {
            //Debug.Log("Box went through!");
            Destroy(this.gameObject, 0.1f);
        }
    }
}
