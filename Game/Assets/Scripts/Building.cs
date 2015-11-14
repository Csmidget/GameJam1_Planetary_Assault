using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {

    int health;
    //float money;
    

	// Use this for initialization
	void Start () 
    {
        health = 100;
       // money = 10f;
	}
	
	// Update is called once per frame
	void Update () 
    {
 
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bomb" && health >= 0)
        {
            int dmgTaken = col.gameObject.GetComponent<Bomb>().GetDamage();
            health -= dmgTaken;
            Destroy(col.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }
}
