using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Transform planet;           //used to store a planet transform.

	// Use this for initialization
	void Start () 
    {
        planet = GameObject.FindGameObjectWithTag("Planet").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        float rot = 5f;         //rot stands for rotate or rotation
        if (Input.GetKey(KeyCode.A))
        {
            planet.Rotate(-Vector3.forward * rot * Time.deltaTime);               
        }

        if (Input.GetKey(KeyCode.D))
        {
            planet.Rotate(Vector3.forward * rot * Time.deltaTime);
        }
	   
	}
}
