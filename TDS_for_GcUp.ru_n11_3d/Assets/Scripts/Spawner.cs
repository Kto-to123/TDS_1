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
    public bool enemyLVLUp = false;
    public GameObject enemyLVL1;
    public GameObject enemyLVL2;
    public GameObject enemyLVL3;

    GameObject MyUI;
    UIScript MyUIScript;

    private void Start()
    {
        MyUI = GameObject.FindGameObjectWithTag("UI");
        MyUIScript = MyUI.GetComponent<UIScript>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player" && !enemyLVLUp)
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
        else if (collision.tag == "Player" && enemyLVLUp)
        {
            if (MyUIScript.kils >= 10 && MyUIScript.kils < 20)
            {
                for (int i = 0; i < nomber; i++)
                {
                    Instantiate(enemyLVL2, new Vector3(point.transform.position.x + (i * 2), point.transform.position.y, point.transform.position.z), transform.rotation);
                }
            }
            else if (MyUIScript.kils >= 20)
            {
                for (int i = 0; i < nomber; i++)
                {
                    Instantiate(enemyLVL3, new Vector3(point.transform.position.x + (i * 2), point.transform.position.y, point.transform.position.z), transform.rotation);
                }
            }
            else
            {
                for (int i = 0; i < nomber; i++)
                {
                    Instantiate(enemyLVL1, new Vector3(point.transform.position.x + (i * 2), point.transform.position.y, point.transform.position.z), transform.rotation);
                }
            }
            //Debug.Log(MyUIScript.kils.ToString());
        }
    }
}
