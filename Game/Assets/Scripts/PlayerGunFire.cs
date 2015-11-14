﻿using UnityEngine;
using System.Collections;

public class PlayerGunFire : MonoBehaviour
{

    public Transform projectileSpawner;      //used to store the bulletSpawn transform, used for spawning the prefab position
    public Transform bombProjectile;
    public Transform laserProjectile;

    float timer, timerCap;
    float timer2, timer2Cap;

	// Use this for initialization
	void Start ()
    {
        timer = 0.5f;
        timerCap = 0.5f;
        timer2 = 0.5f;
        timer2Cap = 0.1f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Fire();
	}

    void Fire()
    {
        timer -= Time.deltaTime;
        timer2 -= Time.deltaTime;
        //print(timer2);

        if (Input.GetKey(KeyCode.Space) && timer <= 0)
        {
            SpawnProjectile(bombProjectile);
            timer = timerCap;
        }
        if (timer2 <= 0)
        {
            SpawnProjectile(laserProjectile);
            timer2 = timer2Cap;
        }

        if (timer < 0)
        {
            timer = 0;
        }
        if (timer2 < 0)
        {
            timer2 = 0;
        }
    }

    void SpawnProjectile(Transform proj)
    {
        Transform projectile = (Transform)Instantiate(proj, projectileSpawner.position, transform.rotation);
    }

    float GetTimerCap()
    {
        return timerCap;
    }

    float GetTimer()
    {
        return timer;
    }
}
