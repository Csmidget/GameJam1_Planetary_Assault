using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoretext : MonoBehaviour {

    Text sText;

    void UpdateScoreUI() 
    {
        sText.text = "Score: " + PlayerState.instance.pScore;
      //  GetComponent<Text>().text = sText.text;
    }


	// Use this for initialization
	void Start () {
        sText = GetComponent<Text>(); 
        PlanetAttackState.instance.BuildingDestroyed += UpdateScoreUI;

	}
	
	// Update is called once per frame
	void Update () {


	}
}
