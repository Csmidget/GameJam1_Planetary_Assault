using UnityEngine;
using System.Collections;

public class Gamestate : MonoBehaviour
{
    bool isPaused = false;
    bool lvl1Cleared = false;
    bool lvl2Cleared = false;
    bool lvl3Cleared = false;
    bool lvl4Cleared = false;
    bool lvl5Cleared = false;

    [SerializeField]

    public static Gamestate instance = null;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Singleton GameState already found...");
        }
        instance = this;
        Object.DontDestroyOnLoad(transform.gameObject);
    }

    void Update()
    {
        //Main Menu
        if (Application.loadedLevel == 0)
        {
            if (lvl1Cleared)
            {
                //Unlock level 2
                //lvl
            }
            if (lvl2Cleared)
            {
                //Unlock level 3
            }
            if (lvl3Cleared)
            {
                //Unlock level 4
            }
            if (lvl4Cleared)
            {
                //Unlock level 5
            }
            if (lvl5Cleared)
            {
                //Player Wins!
            }
        }
    }
}
