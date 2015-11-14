using UnityEngine;
using System.Collections;

public class E_Missle : MonoBehaviour {

    Rigidbody2D rb;
    float thrust;

	// Use this for initialization
	void Start () 
    {
        rb = GetComponent<Rigidbody2D>();
        thrust = 2f;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        rb.AddForce(transform.up * thrust);
	}
}
