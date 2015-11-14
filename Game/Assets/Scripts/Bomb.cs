using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

    int damage;
    //Rigidbody2D rig;
    Transform trans;
    float force;

	// Use this for initialization
	void Start () 
    {
        damage = 30;
        trans = GetComponent<Transform>();
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
        trans.Translate(-Vector3.up * 5 * Time.deltaTime);
    }
}
