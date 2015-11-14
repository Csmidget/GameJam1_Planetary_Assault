using UnityEngine;
using System.Collections;

public class BombUIScript : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
	player = GameObject.FindGameObjectWithTag("Player")
    player.GetComponent<PlayerGunFire>().
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
