﻿using UnityEngine;
using System.Collections;

public class BuildingSpawner : MonoBehaviour {

	public int numberOfBuildings = 30;
	public GameObject[] buildings;
	public Transform planet;
	public Transform buildingPrefab;
	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < numberOfBuildings; i++)
		{
			GameObject go = (Instantiate (buildingPrefab,new Vector3 (0, 0, 0),Quaternion.identity) as GameObject);
	//		go.transform.parent = planet.transform;
			Transform goTransform;
			goTransform = go.GetComponent<Transform>();
			goTransform.parent = planet.transform;
			goTransform.position = planet.position;
			goTransform.Rotate(new Vector3(1,0,0));
			goTransform.Translate (new Vector3(0,planet.GetComponent<CircleCollider2D>().radius));
			buildings[i] = go;
		}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
