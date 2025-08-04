using UnityEngine;

public class BrainAnimationController : MonoBehaviour
{
    public Animator brainAnimator;

    public void PlayDissect()
    {
        brainAnimator.SetTrigger("Dissect");
    }

    public void PlayRejoin()
    {
        brainAnimator.SetTrigger("Rejoin");
    }
}
