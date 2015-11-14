using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

    int damage;
    Rigidbody2D rig;
    float force;

	// Use this for initialization
	void Start () 
    {
        damage = 30;
        rig = GetComponent<Rigidbody2D>();
        force = 5f;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Travel();
	}

    public int GetDamage()
    {
        return damage;
    }

    void Travel()
    {
        rig.AddForce(-transform.up * force);
    }
}
