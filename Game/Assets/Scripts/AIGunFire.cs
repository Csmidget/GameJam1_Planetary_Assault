using UnityEngine;
using System.Collections;

public class AIGunFire : MonoBehaviour 
{
    float timer;
<<<<<<< HEAD
   // float timer2;
=======
>>>>>>> origin/master
    public Transform bulletSpawner;
    public Transform bulletPrefab;
    //public Transform missilePrefab;

	// Use this for initialization
	void Start () 
    {
        timer = 2.0f;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Fire();
	}

    void Fire()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            SpawnProjectile();
            timer = 0.5f;
        }

<<<<<<< HEAD
        /*if (timer2 > 0)
        {
            timer2 -= Time.deltaTime;
        }
        else
        {
            SpawnMissile();
            timer = 10f;
        }*/
=======

>>>>>>> origin/master
    }

    void SpawnProjectile()
    {
        Instantiate(bulletPrefab, bulletSpawner.position, transform.rotation);
    }
<<<<<<< HEAD
    /*void SpawnMissile()
    {
        Instantiate(missilePrefab, bulletSpawner.position, transform.rotation);
    }*/
=======

>>>>>>> origin/master
}
