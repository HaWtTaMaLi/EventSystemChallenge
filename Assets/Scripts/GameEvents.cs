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
    public static event Action onColourClick; //instance = this was NOT working 

    public Button spawnButton;
    public Button colourButton;

    public void Start()
    {
       //instance = this;

        //Listeners
        spawnButton.onClick.AddListener(() => AllEvents[0].Event.Invoke());
        colourButton.onClick.AddListener(() => AllEvents[1].Event.Invoke());
    }

    public void SpawnClick()
    {
        if (onSpawnClick != null)
        {
            onSpawnClick();
            //Debug.Log("Listening to SpawnClick");
        }
    }

    public void ColourClick()
    {
        if (onColourClick != null)
        {
            onColourClick();
            //Debug.Log("Listening to KillClick");
        }
    }
}
//notes you can add a image to button and drag it to Target Graphic in button editor and change it to sprite swap to have cool visuals
