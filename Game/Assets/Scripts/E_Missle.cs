using UnityEngine;
using System.Collections;

public class E_Missle : MonoBehaviour {
    public Transform playerShip;        //stores the players position.
    Vector3 storeTransform;     //stores the trasnform once to a vector3, this is so the missle doesnt home in.
    

    float thrust;
    float damage;

	// Use this for initialization
	void Start () 
    {
        storeTransform = playerShip.position;
        thrust = 5f;
	}
	
	// Update is called once per frame
	void Update() 
    {
        transform.Translate(Vector3.Slerp(transform.up * thrust, storeTransform, 0.5f));
	}


}
