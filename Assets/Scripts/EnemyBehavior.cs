using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehavior : MonoBehaviour
{


    public GameObject bullet;
    public float bulletSpeed = 2f;
    public Transform firePoint2;

    // Enemy Death Srcipt
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Bullet")
        {
            Destroy(this.gameObject);
            Score.playerScore += 9;
            
        }

    }


  

    // Enemy Attack Code
    private float firecountdown = 0;
    public float firerate = 1f;

      void Update()
    {
        if (firecountdown <= 0) 
        {
            shoot();
            firecountdown = 1f / firerate;

        }
        firecountdown -= Time.deltaTime;

    }


    void shoot()
    {
        GameObject newBullet = Instantiate(bullet, firePoint2.position, firePoint2.rotation);

        Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();

        bulletRB.velocity = this.transform.TransformDirection(Vector3.back) * bulletSpeed;
    }



}
