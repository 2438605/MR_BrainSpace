using UnityEngine;
using UnityEngine.SceneManagement;

public class PlacementZone : MonoBehaviour
{
    public string correctTag; // The tag of the correct brain part
    private bool isFilled = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isFilled && other.CompareTag(correctTag))
        {
            // Snap to zone position
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;

            // Prevent further dragging
            Destroy(other.GetComponent<DraggablePart>());

            // Add to score
            ScoreManager.Instance.AddPoint();
            Debug.Log("Correctly placed: " + correctTag);

            isFilled = true;
        }
    }
}
