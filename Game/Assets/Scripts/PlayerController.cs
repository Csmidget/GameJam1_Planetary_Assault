using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Transform planet;           //used to store a planet transform.
    Vector3 mousePos;

	// Use this for initialization
	void Start () 
    {
        planet = GameObject.FindGameObjectWithTag("Planet").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        float rot = 5f;         //rot stands for rotate or rotation
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));      //this gets the mouse position and stores it in a vector called mouse pos. 

        if (Input.GetKey(KeyCode.A))
        {
            planet.Rotate(-Vector3.forward * rot * Time.deltaTime);               
        }

        if (Input.GetKey(KeyCode.D))
        {
            planet.Rotate(Vector3.forward * rot * Time.deltaTime);
        }

        transform.position = Vector3.Slerp(transform.position, mousePos, 0.1f);         //this then user linear interpolation to smooth out the trasnition from ships position to mouse.
       
	}
}
