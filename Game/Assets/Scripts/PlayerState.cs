using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour 
{
    public int pHealth;
    public int pScore;
    //public pMoney;

    void IncrementScore()
    {
        pScore += 100;
        print(pScore);
    }

    void Awake()
    {
        Object.DontDestroyOnLoad(transform.gameObject);
    }

	// Use this for initialization
	void Start () 
    {
        PlanetAttackState.instance.BuildingDestroyed += IncrementScore;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.P))
        {
            Application.LoadLevel("testscene");
        }
	}
}
