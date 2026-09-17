using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class Events
{
    public string Name;
    public UnityEvent Event;
}

public class GameEvents : MonoBehaviour
{
    //public static GameEvents instance;
    
    public Events[] AllEvents;
    public static event Action onSpawnClick; //Adding STATIC saved my lifeeeeee
    public static event Action onKillClick; //instance = this was NOT working 

    public Button spawnButton;
    public Button killButton;

    public void Start()
    {
       //instance = this;

        //Listeners
        spawnButton.onClick.AddListener(() => AllEvents[0].Event.Invoke());
        killButton.onClick.AddListener(() => AllEvents[1].Event.Invoke());
    }


    public void SpawnClick()
    {
        if (onSpawnClick != null)
        {
            onSpawnClick();
            //Debug.Log("Listening to SpawnClick");
        }
    }

    public void KillClick()
    {
        if (onKillClick != null)
        {
            onKillClick();
            //Debug.Log("Listening to KillClick");
        }
    }
}
