using UnityEngine;

public class PrefabSwapper : MonoBehaviour
{
    public GameObject currentObject;      // The current brain object in the scene
    public Transform spawnPoint;          // Where to spawn the new prefab
    public GameObject newPrefab;          // The prefab to swap in

    public void SwapPrefab()
    {
        if (currentObject != null)
        {
            Destroy(currentObject);
        }

        currentObject = Instantiate(newPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
