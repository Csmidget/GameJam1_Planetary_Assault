using UnityEngine;
using System.Collections;

public class AIGunFire : MonoBehaviour 
{
    float timer;

    public Transform bulletSpawner;
    public Transform bulletPrefab;

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
    }

    void SpawnProjectile()
    {
        Instantiate(bulletPrefab, bulletSpawner.position, transform.rotation);
    }
}
