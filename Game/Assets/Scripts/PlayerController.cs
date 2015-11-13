using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Transform planet;           //used to store a planet transform.
<<<<<<< HEAD
    public Transform bulletSpawner;      //used to store the bulletSpawn transform, used for spawning the prefab position
    public Transform bulletPrefab;      
=======
    Transform bg;               //background
>>>>>>> origin/master
    Vector3 mousePos;
    float rot;                  //rot stands for rotate or rotation

	// Use this for initialization
	void Start () 
    {
        planet = GameObject.FindGameObjectWithTag("Planet").transform;
<<<<<<< HEAD
        rot = 5f;         
=======
        bg = GameObject.FindGameObjectWithTag("BG").transform;
>>>>>>> origin/master
	}
	
	// Update is called once per frame
	void Update () 
    {
<<<<<<< HEAD
        Controls();

	}

    void Controls()
    {
=======
        float rotP = 5f; //rot stands for rotate or rotation
        float rotBG = 2f;
>>>>>>> origin/master
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));      //this gets the mouse position and stores it in a vector called mouse pos. 

        if (Input.GetKey(KeyCode.A))
        {
<<<<<<< HEAD
            planet.Rotate(-Vector3.forward * rot * Time.deltaTime);
=======
            planet.Rotate(-Vector3.forward * rotP * Time.deltaTime);
            bg.Rotate(-Vector3.forward * rotBG * Time.deltaTime);
>>>>>>> origin/master
        }

        if (Input.GetKey(KeyCode.D))
        {
            planet.Rotate(Vector3.forward * rotP * Time.deltaTime);
            bg.Rotate(Vector3.forward * rotBG * Time.deltaTime);
        }

        transform.position = Vector3.Lerp(transform.position, mousePos, 0.1f);         //this then user linear interpolation to smooth out the trasnition from ships position to mouse.
       

    }

    void Fire()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, bulletSpawner.position, Quaternion.identity);
        }
    }
}
