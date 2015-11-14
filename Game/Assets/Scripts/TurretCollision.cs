using UnityEngine;
using System.Collections;

public class TurretCollision : MonoBehaviour
{
    int health;
	// Use this for initialization
	void Start ()
    {
        health = 150;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bomb" && health >= 0)
        {
            int dmgTaken = col.gameObject.GetComponent<ProjectileDamage>().GetDamage();
            health -= dmgTaken;
            Destroy(col.gameObject);
        }

        if (health <= 0)
        {
            PlanetAttackState.instance.BuildingDestroyed();
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
