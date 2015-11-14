using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

    Transform trans;
    float force;

	// Use this for initialization
	void Start () 
    {
        trans = GetComponent<Transform>();
        force = 5f;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Travel();
	}

    void Travel()
    {
        trans.Translate(-Vector3.up * 5 * Time.deltaTime);
    }
}
