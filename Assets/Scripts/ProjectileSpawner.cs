using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject ballPrefab;

    public void CreateBall()
    {
        GameObject ball = Instantiate(ballPrefab, ballPrefab.transform.position, Quaternion.identity);
        ball.GetComponent<MeshRenderer>().enabled = false;
        ball.gameObject.SetActive(true);
        ball.name = "Projectile";
        ball.transform.parent = this.transform;
        ball.GetComponent<Renderer>().material.color = new Color (Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f));        
    }

    
}
