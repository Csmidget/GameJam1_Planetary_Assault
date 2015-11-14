using UnityEngine;
using System.Collections;

public class AIGunState : MonoBehaviour 
{
    private AIGunAim aiGunAim;
    private AIGunFire aiGunFire;
	// Use this for initialization
	void Start () 
    {
        aiGunAim = GetComponent<AIGunAim>();
        aiGunFire = GetComponent<AIGunFire>();
        aiGunAim.enabled = false;
        aiGunFire.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnBecameVisible()
    {
        aiGunAim.enabled = true;
        aiGunFire.enabled = true;
    }

    void OnBecameInvisible()
    {
        aiGunAim.enabled = false;
        aiGunFire.enabled = false;
    }
}
