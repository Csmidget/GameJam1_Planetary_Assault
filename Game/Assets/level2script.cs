using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class level2script : MonoBehaviour {


    public Sprite planet;
    public Sprite PlanetLocked;

	// Use this for initialization
	void Start () {
        if (Gamestate.instance.lvl1Cleared == false) GetComponent<Button>().image.overrideSprite = PlanetLocked;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
