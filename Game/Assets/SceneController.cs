using UnityEngine;
using System.Collections;
using System;

public class SceneController : MonoBehaviour
{
    
    [SerializeField]

    public static SceneController instance = null;

    public void IncreaseHP()
    {
        
        if (PlayerState.instance.pScore >= 2000)
        {
        PlayerState.instance.pMaxHealth += 10;
        PlayerState.instance.pScore-=2000;
        }
    }

    public void DecreaseFireRate()
    {

        if (PlayerState.instance.pScore >= 3000 && PlayerState.instance.pFireRate > 0.05f)
        {
            PlayerState.instance.pFireRate -= 0.05f;
            PlayerState.instance.pScore -= 3000;
        }
    }

    public void DecreaseBCool()
    {

        if (PlayerState.instance.pScore >= 4000 && PlayerState.instance.pBombCool > 3f)
        {
            PlayerState.instance.pBombCool -= 1f;
            PlayerState.instance.pScore -= 4000;
        }

    }


    void Start()
    {
       
    }


    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Singleton SceneController already found...");
        }

        instance = this;
    }


    void Update()
    {
     
    }

}
