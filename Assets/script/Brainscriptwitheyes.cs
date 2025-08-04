using UnityEngine;

public class BrainWithEyesAnimationController : MonoBehaviour
{
    public Animator brainWithEyesAnimator;

    public void PlayDissect()
    {
        brainWithEyesAnimator.SetTrigger("Dissect");
    }

    public void PlayRejoin()
    {
        brainWithEyesAnimator.SetTrigger("Rejoin");
    }
}
