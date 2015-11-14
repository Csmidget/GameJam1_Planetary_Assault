﻿using UnityEngine;
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

    public static PlanetAttackState instance = null;

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
        PausingGame();
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
