using UnityEngine;
using System.Collections;

public class PlayerGunFire : MonoBehaviour
{

    public Transform projectileSpawner;      //used to store the bulletSpawn transform, used for spawning the prefab position
    public Transform projectilePrefab;
    Transform projectile;
    float timer;

	// Use this for initialization
	void Start ()
    {
        timer = 0.5f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Fire();
	}

    void Fire()
    {
        timer -= Time.deltaTime;
        print(timer);
        if (Input.GetKey(KeyCode.Space) && timer <= 0)
        {
            SpawnProjectile();
            timer = 0.5f;
        }

        if (timer < 0)
        {
            timer = 0;
        }
    }

    void SpawnProjectile()
    {
        projectile = (Transform)Instantiate(projectilePrefab, projectileSpawner.position, transform.rotation);
    }
}
