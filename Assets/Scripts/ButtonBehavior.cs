using UnityEngine;
using UnityEngine.Events;

//notes you can add a image to button and drag it to Target Graphic in button editor and change it to sprite swap to have cool visuals

public class ButtonBehavior : MonoBehaviour
{
    //Do button Stuff
    public Object spawnedObject;


    public UnityEvent onButtonClick; //this didnt work :(
    //still have to use the OnClick in Button on the inspector 

    private void Start()
    {
        //subscribe
        GameEvents.instance.onSpawnClick += SpawnButton;
        GameEvents.instance.onKillClick += KillButton;
        
    }

    public void SpawnButton()
    {
        //if i change the ID number in the inspector it stops working...
        //Works with 0 does now work with 1

        //probably dont need ID unless you have many
        //if (id == this.id) //index ID property
        //{
        //do spawn button stuff
        //Debug.Log("Spawn Button Clicked");
        //}


        //do spawn button stuff
        Debug.Log("Spawn Button Clicked");
    }

    public void KillButton()
    {
        //if (id == this.id)
        //{
        //do kill button stuff
        //Debug.Log("Kill Button Clicked");
        //}

        //do kill button stuff
        Debug.Log("Kill Button Clicked");
    }

    private void OnDestroy()
    {
        //Unsubscribe
        GameEvents.instance.onSpawnClick -= SpawnButton;
        GameEvents.instance.onKillClick -= KillButton;
        //if the object is destroyed unsubscribe to avoid null errors
    }
}
