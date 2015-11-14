using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
    int damage;

	// Use this for initialization
	void Start () 
    {
        damage = 30;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public int GetDamage()
    {
        return damage;
    }
}
