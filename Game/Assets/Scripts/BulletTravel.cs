using UnityEngine;
using System.Collections;

public class BulletTravel : MonoBehaviour 
{
    float speed;
	// Use this for initialization

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerState.instance.pHealth --;
            Destroy(gameObject);
        }

    }

	void Start () 
    {
        speed = 15f;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Move();
	}

    void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
