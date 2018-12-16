using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting2 : MonoBehaviour {

    public GameObject Bullet;
    public GameObject Point;
    public GameObject Weapons1;
    public GameObject Weapons2;
    public GameObject Weapons3;

    GameObject Weapons;
    int repied = 2;
    bool weaponsRepiad = true;


    private void Start()
    {
        if (RoomManager.Inst.Weapon == 1)
        {
            Weapons = Weapons3;
        }
        else if (RoomManager.Inst.Weapon == 3)
        {
            Weapons = Weapons1;
        }
        else
        {
            Weapons = Weapons2;
        }
    }

    void Update () {
        if (Input.GetMouseButtonDown(0) && repied > 0)
        {
            for (float i = -0.03f; i < 0.03f; i += 0.01f)
            {
                Quaternion Qua1 = new Quaternion(transform.rotation.x, transform.rotation.y + i, transform.rotation.z, transform.rotation.w);
                Instantiate(Bullet, new Vector3(Point.transform.position.x, Point.transform.position.y, Point.transform.position.z), Qua1);
            }
            //Instantiate(Bullet, new Vector3(Point.transform.position.x, Point.transform.position.y, Point.transform.position.z), transform.rotation);

            repied--;
            if (repied < 1)
            {
                StartCoroutine("Repied");
            }
        }

        if (Input.GetMouseButtonDown(1) && weaponsRepiad)
        {
            Weapons.SetActive(true);
            weaponsRepiad = false;
            StartCoroutine("WeapinActiv");
        }
    }

    IEnumerator WeapinActiv()
    {
        yield return new WaitForSeconds(0.2f);
        StartCoroutine("WeapinNoActiv");
    }

    IEnumerator WeapinNoActiv()
    {
        Weapons.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        weaponsRepiad = true;
    }

    IEnumerator Repied()
    {
        yield return new WaitForSeconds(2f);
        repied = 2;
    }
}
