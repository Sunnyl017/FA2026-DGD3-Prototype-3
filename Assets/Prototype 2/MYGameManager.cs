using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
public class MYGameManager : MonoBehaviour
{
    public GameObject gO;
    public float timer;
    public float enemyTimer;
    public GameObject enemies;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 5;
        enemyTimer = 5;
        for (float i = 0; i < 3; i++)
        {
            Instantiate(gO, new Vector3(Random.Range(-10, 16), Random.Range(-4, 8), 0), Quaternion.Euler(0, 0, 0));
            Instantiate(enemies, new Vector3(Random.Range(-8, -10), Random.Range(-2, 8), 0), Quaternion.Euler(0, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(gO, new Vector3(Random.Range(-10, 16), Random.Range(-4, 8), 0), Quaternion.Euler(0, 0, 0));
            timer = 5;
        }
       enemyTimer -= Time.deltaTime;

        
        {
            if (enemyTimer < 0)
            {
                if (enemies.activeInHierarchy== false)
                {
                    Instantiate(enemies, new Vector3(Random.Range(-8, -10), Random.Range(-2, 8), 0), Quaternion.Euler(0, 0, 0));
                    enemyTimer = 5;
                }
                else
                {
                    enemyTimer = 5;
                }

            }
        }
    }
}
