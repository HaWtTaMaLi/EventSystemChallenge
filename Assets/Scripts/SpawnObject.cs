using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    //Do Spawn Stuff
    public Object spawnedObject;

    private void Start()
    {
        //Subscribed
        GameEvents.onSpawnClick += SpawnButton;
    }

    public void SpawnButton()
    {
        //do spawn button stuff
        Debug.Log("Spawn Object");
    }

    private void OnDestroy()
    {
        //Unsubscribe
        GameEvents.onSpawnClick -= SpawnButton;
    }
}
