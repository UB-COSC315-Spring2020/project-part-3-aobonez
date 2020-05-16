using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
   
    public GameObject EnemyShip;
    public Transform enemySpawn;
    public int enemycount = 0;
    public int enemyXPos;
    public float fightspeed = 50f;

    void Update()
    {
        if(enemycount <= 10)
        {
          EnemyBirth();
          enemycount +=1 ;
        }

        else if (enemycount == 5)
        {
            enemycount += 5;
        }


    }


    // This Creates New Enemies
    public void EnemyBirth()
    {
       
            enemyXPos = Random.Range(-58, 65);
            GameObject newEmemy = Instantiate(EnemyShip, new Vector3(enemyXPos, 7, 14), enemySpawn.rotation) as GameObject;

            Rigidbody Enemymove = EnemyShip.GetComponent<Rigidbody>();

            Enemymove.velocity = transform.TransformDirection(Vector3.back) * fightspeed;
          


    }







}

