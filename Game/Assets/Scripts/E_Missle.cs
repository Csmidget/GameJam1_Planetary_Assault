using UnityEngine;
using System.Collections;

public class E_Missle : MonoBehaviour {
    public Transform playerShip;        //stores the players position.
    Vector3 storeTransform;     //stores the trasnform once to a vector3, this is so the missle doesnt home in.
    Rigidbody2D rb;
    float thrust;

	// Use this for initialization
	void Start () 
    {
        rb = GetComponent<Rigidbody2D>();
        storeTransform = playerShip.position;
        
        thrust = 2f;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        rb.AddForce(Vector3.Slerp(transform.up * thrust, storeTransform, 0.5f));
	}


}
