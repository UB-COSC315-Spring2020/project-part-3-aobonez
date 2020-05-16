using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    
    //Movement
    public float zSpeed = 10f;
    public float xSpeed = 75f;
    Vector3 Movement;
    private Rigidbody _rb;

    //Shooting
    public GameObject bullet;
    public float bulletSpeed = 100f;
    public Transform firePoint;

   
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement.z = Input.GetAxis("Vertical") * zSpeed;
        Movement.x = Input.GetAxis("Horizontal") * xSpeed;


    }

    private void FixedUpdate()
    {
        //Movement Code
        _rb.MovePosition(_rb.position + Movement * Time.fixedDeltaTime);

        // Shooting Code
        if(Input.GetMouseButtonDown(0))
        {
        GameObject newBullet = Instantiate(bullet, firePoint.position
         , firePoint.rotation) as GameObject;

        Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();

        bulletRB.velocity = this.transform.TransformDirection(Vector3.back) * bulletSpeed;
    }

    }

    //Player Health / Death code
    public float playerHealth = 100f;
   

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Bullet")
        {
            playerHealth -= 25f;
            

        }

        if (playerHealth == 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("MainMenu");
        }
    }
}
