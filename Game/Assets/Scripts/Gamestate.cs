using UnityEngine;
using System.Collections;

public class Gamestate : MonoBehaviour
{

    [SerializeField]

    public static Gamestate instance = null;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Singleton GameState already found...");
        }
        instance = this;
    }
}
