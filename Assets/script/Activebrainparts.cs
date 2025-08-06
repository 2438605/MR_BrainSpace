using UnityEngine;

public class ActivateBrainParts : MonoBehaviour
{
    public GameObject[] brainParts; // Assign in Inspector

    // Call this function from a button
    public void ShowBrainParts()
    {
        foreach (GameObject part in brainParts)
        {
            if (part != null)
            {
                part.SetActive(true);
                Debug.Log("Activated: " + part.name);
            }
        }
    }
}
