﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (Gamestate.instance.haveplayed == false)
        {
            GetComponent<Button>().interactable = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
