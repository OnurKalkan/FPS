using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int speed = 1000;
    public bool auto, semi_auto;
    void Update()
    {
        if (Input.GetMouseButton(0) && auto && transform.childCount == 4)
        {
            GameObject proj = transform.Find("Projectile").gameObject;
            proj.transform.parent = null;
            proj.GetComponent<MeshRenderer>().enabled = true;
            proj.GetComponent<Rigidbody>().useGravity = true;
            proj.GetComponent<Rigidbody>().isKinematic = false;
            proj.GetComponent<Rigidbody>().AddForce(transform.Find("Sample Projectile").transform.forward * speed);
            StartCoroutine(BallDestroyer(proj));
            Invoke(nameof(NewProjectile), 0.05f);
        }
        else if (Input.GetMouseButtonDown(0) && semi_auto)
        {
            GameObject proj = transform.Find("Projectile").gameObject;
            proj.transform.parent = null;
            proj.GetComponent<MeshRenderer>().enabled = true;
            proj.GetComponent<Rigidbody>().useGravity = true;
            proj.GetComponent<Rigidbody>().isKinematic = false;
            proj.GetComponent<Rigidbody>().AddForce(transform.Find("Sample Projectile").transform.forward * speed);
            StartCoroutine(BallDestroyer(proj));
            Invoke(nameof(NewProjectile), 0.05f);
        }
        if(auto && Input.GetKeyDown(KeyCode.Q))
        {
            auto = false;
            semi_auto = true;
            print("semi-auto");
        }
        else if (semi_auto && Input.GetKeyDown(KeyCode.Q))
        {
            semi_auto = false;
            auto = true;
            print("auto");
        }
    }
    void NewProjectile()
    {
        GetComponent<ProjectileSpawner>().CreateBall();
    }

    IEnumerator BallDestroyer(GameObject proj)
    {
        yield return new WaitForSeconds(3);
            Destroy(proj);
    }

}
