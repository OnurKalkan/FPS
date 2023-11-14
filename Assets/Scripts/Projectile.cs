using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int speed = 1000;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject proj = transform.Find("Projectile").gameObject;
            proj.transform.parent = null;
            proj.GetComponent<Rigidbody>().useGravity = true;
            proj.GetComponent<Rigidbody>().isKinematic = false;
            proj.GetComponent<Rigidbody>().AddForce(transform.Find("Sample Projectile").transform.forward * speed);
            Invoke(nameof(NewProjectile), 0.1f);
        }
    }
    void NewProjectile()
    {
        GetComponent<ProjectileSpawner>().CreateBall();
    }

}
