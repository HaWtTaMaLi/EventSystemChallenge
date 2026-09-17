using System;
using UnityEngine;
using UnityEngine.Events;

public class GameEvents : MonoBehaviour
{
    //do game events here 
    //subscribes? 

    public static GameEvents instance;

    private void Awake()
    {
        instance = this;
    }

    public event Action onSpawnClick; //public event Action onSpawnClick- if you dont want to add ID
    public event Action onKillClick;


    public void SpawnClick()
    {
        if(onSpawnClick != null)
        {
            onSpawnClick();
        }
    }

    public void KillClick()
    {
        if (onKillClick != null)
        {
            onKillClick();
        }
    }
}
