using UnityEngine;
using UnityEngine.Events;

//notes you can add a image to button and drag it to Target Graphic in button editor and change it to sprite swap to have cool visuals

public class ButtonBehavior : MonoBehaviour
{
    //Do button Stuff
    public Object spawnedObject;

    private void Start()
    {
        //Subscribed
        GameEvents.onSpawnClick += SpawnButton;
        GameEvents.onKillClick += KillButton;

    }

    public void SpawnButton()
    {
        //do spawn button stuff
        Debug.Log("Spawn Button Clicked");
    }

    public void KillButton()
    {
        //do spawn button stuff
        Debug.Log("Kill Button Clicked");
    }

    private void OnDestroy()
    {
        GameEvents.onSpawnClick -= SpawnButton;
        GameEvents.onKillClick -= KillButton;
    }
}
