using UnityEngine;
using System.Collections;
using System;

public class PlanetAttackState : MonoBehaviour
{
    public Action BuildingDestroyed = null;

 //   public void InitBuildingDestroyed()
 //   {
 //      BuildingDestroyed();
 //   }



    [SerializeField]

  

    public float firerate;

    public static PlanetAttackState instance = null;

    void Start()
    {
        PlayerState.instance.StartListening();
        Gamestate.instance.haveplayed = true;
        PlayerState.instance.pHealth = PlayerState.instance.pMaxHealth;
    }


    public void WinLevel()
    {
        PlayerState.instance.pHealth = PlayerState.instance.pMaxHealth;
        if(Application.loadedLevel == 1) Gamestate.instance.lvl1Cleared = true;
        if(Application.loadedLevel == 2) Gamestate.instance.lvl2Cleared = true;
        if(Application.loadedLevel == 3) Gamestate.instance.lvl3Cleared = true;
        if(Application.loadedLevel == 4) Gamestate.instance.lvl4Cleared = true;
        Application.LoadLevel("MainMenu");
    }

    public void LoseLevel()
    {
        PlayerState.instance.pHealth = PlayerState.instance.pMaxHealth;
        Application.LoadLevel("MainMenu");
    }


    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Singleton PlanetAttackState already found...");
        }

        Cursor.visible = false;
        instance = this;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
        PausingGame();
        if (PlayerState.instance.pHealth <= 0) LoseLevel();
    }

    void PausingGame()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }

    }
}
