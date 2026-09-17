using UnityEngine;

public class ColourObject : MonoBehaviour
{
    //Do Colour Stuff
    public Object colouredObject;

    private void Start()
    {
        //Subscribed
        GameEvents.onColourClick += ColourButton;
    }

    public void ColourButton()
    {
        //do change colour stuff
        Debug.Log("Change Object Colour");
    }

    private void OnDestroy()
    {
        //Unsubscribe
        GameEvents.onColourClick -= ColourButton;
    }
}
