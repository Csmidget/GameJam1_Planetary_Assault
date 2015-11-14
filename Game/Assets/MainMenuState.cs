using UnityEngine;
using System.Collections;
using System;

public class MainMenuState : MonoBehaviour
{

    //   public void InitBuildingDestroyed()
    //   {
    //      BuildingDestroyed();
    //   }



    [SerializeField]

    public static MainMenuState instance = null;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Singleton MainMenuState already found...");
        }

        Cursor.visible = true;
        instance = this;
    }
    void Update()
    {

    }
}
