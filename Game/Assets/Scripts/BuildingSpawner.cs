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

            //FIX THIS
            if (randnum == 0)
            {
                Transform go = (Transform)GameObject.Instantiate(buildingPrefab1, new Vector3(0, 0, 0), Quaternion.identity);
                Transform goTransform;
                goTransform = go.GetComponent<Transform>();
                goTransform.parent = planet.transform;
                goTransform.position = planet.position;
                goTransform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));
                goTransform.Translate(new Vector3(0, planet.GetComponent<CircleCollider2D>().radius * planet.localScale.x + 0.3f));
                buildings[i] = go;
            }
            
            else
            {
                Transform go = (Transform)GameObject.Instantiate(buildingPrefab2, new Vector3(0, 0, 0), Quaternion.identity);
                Transform goTransform;
                goTransform = go.GetComponent<Transform>();
                goTransform.parent = planet.transform;
                goTransform.position = planet.position;
                goTransform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));
                goTransform.Translate(new Vector3(0, planet.GetComponent<CircleCollider2D>().radius * planet.localScale.x + 0.3f));
                buildings[i] = go;
            };

	//		go.transform.parent = planet.transform;
		//	Transform goTransform;
		//	goTransform = go.GetComponent<Transform>();
       //     goTransform.parent = planet.transform;
		//	goTransform.position = planet.position;
	//		goTransform.Rotate(new Vector3(0,0,Random.Range(0,360)));
	//		goTransform.Translate (new Vector3(0,planet.GetComponent<CircleCollider2D>().radius * planet.localScale.x + 0.3f));
	//		buildings[i] = go;
		}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
