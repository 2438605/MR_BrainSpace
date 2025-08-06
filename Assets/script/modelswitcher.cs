using UnityEngine;

public class ModelSwitcher : MonoBehaviour
{
    public GameObject brainModel;
    public GameObject skullModel;
    public GameObject[] brainParts; // Assign 3 draggable parts here

    public void SwitchToSkullScene()
    {
        // Hide brain model
        brainModel.SetActive(false);

        // Show skull model
        skullModel.SetActive(true);

        // Show draggable brain parts
        foreach (GameObject part in brainParts)
        {
            part.SetActive(true);
        }
    }
}
