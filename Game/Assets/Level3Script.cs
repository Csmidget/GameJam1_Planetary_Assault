using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Level3Script : MonoBehaviour
{


    public Sprite planet;
    public Sprite PlanetLocked;

    // Use this for initialization
    void Start()
    {
        if (Gamestate.instance.lvl2Cleared == false)
        {
            GetComponent<Button>().image.overrideSprite = PlanetLocked;
            GetComponent<Button>().interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
