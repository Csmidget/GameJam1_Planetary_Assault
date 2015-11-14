﻿using UnityEngine;
using System.Collections;
using System;

public class PlanetAttackState : MonoBehaviour
{
    public Action BuildingDestroyed = null;

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
}