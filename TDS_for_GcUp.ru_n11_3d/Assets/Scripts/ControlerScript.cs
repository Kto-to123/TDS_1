using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerScript : MonoBehaviour {

    //public float speed = 10f;
    //public float acceleration = 100;
    //public float stoper = 20;
    //public GameObject Bullet;
    //public GameObject point;

    //private Vector3 direction;
    //private Rigidbody body;



    public float speed;
    public float stoper = 10;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        rb.velocity = new Vector3(rb.velocity.x / stoper, 0.0f, rb.velocity.z / stoper);
    }




 //   // Use this for initialization
 //   void Start () {
 //       body = GetComponent<Rigidbody>();
 //       body.freezeRotation = true;
 //       //body.gravityScale = 0;
 //   }

 //   void FixedUpdate()
 //   {
 //       body.AddForce(direction * body.mass * speed * acceleration);

 //       //if (Mathf.Abs(body.velocity.x) > speed)
 //       //{
 //       body.velocity = new Vector2(body.velocity.x * speed / stoper, body.velocity.z * speed / stoper);
 //       //}

 //       //if (Mathf.Abs(body.velocity.y) > speed)
 //       //{
 //       // body.velocity = new Vector2(body.velocity.x, Mathf.Sign(body.velocity.y)/* * speed*/);
 //       //}
 //   }

 //   // Update is called once per frame
 //   void Update () {
		
	//}
}
