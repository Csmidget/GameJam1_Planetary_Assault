using UnityEngine;
using System.Collections;

public class BuildingSpawner : MonoBehaviour {

	public int numberOfBuildings = 30;
	public Transform[] buildings;
	public Transform planet;
	public Transform buildingPrefab1;
    public Transform buildingPrefab2;
	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < numberOfBuildings; i++)
		{
            
            int randnum = Random.Range(0,2);
            print(randnum);


            if (randnum == 0)
            {
            buildings[i] = InstantiateOnPlanet.DoInstantiate(buildingPrefab1, planet);
            }
            
            else
            {
            buildings[i] = InstantiateOnPlanet.DoInstantiate(buildingPrefab2, planet);
            };
		}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
