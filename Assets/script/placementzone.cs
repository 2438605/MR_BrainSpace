using UnityEngine;

public class PlacementZone : MonoBehaviour
{
    public string correctTag; // Set this in the Inspector
    private bool isFilled = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isFilled) return;

        // Check if the object has the correct tag
        if (other.CompareTag(correctTag))
        {
            // Snap into place
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;

            // Optional: Disable XR grabbing so it stays put
            var grab = other.GetComponent<UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable>();
            if (grab) grab.enabled = false;

            // Add point
            ScoreManager.Instance.AddPoint();
            Debug.Log("Correct placement: " + other.name);

            isFilled = true;
        }
        else
        {
            Debug.Log("Wrong part placed: " + other.name);
        }
    }
}

