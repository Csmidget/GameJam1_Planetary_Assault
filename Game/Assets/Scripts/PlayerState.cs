using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour
{
	public int pMaxHealth;
    public int pHealth;
    public int pScore;
    //public pMoney;

    void Start()
    {
        PlanetAttackState.instance.BuildingDestroyed += IncrementScore;
		pHealth = pMaxHealth;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Application.LoadLevel("testscene");
        }
    }


    void IncrementScore()
    {
        pScore += 100;
        print(pScore);
    }


    public static PlayerState instance = null;

    void Awake()
    {
        {
            if (instance != null)
            {
                Debug.LogError("Singleton PlayerState already found...");
            }

            Cursor.visible = false;
            instance = this;
        }
        Object.DontDestroyOnLoad(transform.gameObject);



        Debug.Log("++");
    }


}
	// Update is called once per frame

