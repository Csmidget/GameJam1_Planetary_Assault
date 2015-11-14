﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Transform planet;           //used to store a planet transform.

    Transform bg;               //background
    Vector3 mousePos;

	// Use this for initialization
	void Start () 
    {
        planet = GameObject.FindGameObjectWithTag("Planet").transform;        
        bg = GameObject.FindGameObjectWithTag("BG").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Controls();
        RotateToPlanet();
	}

    void Controls()
    {
        float rotP = 5f; //rot stands for rotate or rotation
        float rotBG = 2f;

        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));      //this gets the mouse position and stores it in a vector called mouse pos. 

        if (Input.GetKey(KeyCode.A))
        {
            planet.Rotate(-Vector3.forward * rotP * Time.deltaTime);
            bg.Rotate(-Vector3.forward * rotBG * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            planet.Rotate(Vector3.forward * rotP * Time.deltaTime);
            bg.Rotate(Vector3.forward * rotBG * Time.deltaTime);
        }

        transform.position = Vector3.Lerp(transform.position, mousePos, Time.deltaTime);         //this then user linear interpolation to smooth out the trasnition from ships position to mouse.
    }

    void RotateToPlanet()
    {
        Vector3 pos = transform.position;
        Vector3 dir = planet.position - pos;

        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, -dir);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 1.75f);
    }
}
