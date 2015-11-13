using UnityEngine;
using System.Collections;

public class BuildingSpawner : MonoBehaviour {

	public int numberOfBuildings = 30;
	public Transform[] buildings;
	public Transform planet;
	public Transform buildingPrefab;
	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < numberOfBuildings; i++)
		{
			Transform go = (Transform)GameObject.Instantiate(buildingPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
	//		go.transform.parent = planet.transform;
			Transform goTransform;
			goTransform = go.GetComponent<Transform>();
            goTransform.parent = planet.transform;
			goTransform.position = planet.position;
			goTransform.Rotate(new Vector3(0,0,Random.Range(0,360)));
			goTransform.Translate (new Vector3(0,planet.GetComponent<CircleCollider2D>().radius * planet.localScale.x + 0.5f));
			buildings[i] = go;
		}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
