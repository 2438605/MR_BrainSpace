using UnityEngine;

public class BrainPartHighlighter : MonoBehaviour
{
    public Animator leftHemisphereAnimator;
    public Animator rightHemisphereAnimator;
    public Animator cerebellumAnimator;

    public void HighlightLeft()
    {
        leftHemisphereAnimator.SetTrigger("Highlight");
    }

    public void HighlightRight()
    {
        rightHemisphereAnimator.SetTrigger("Highlight");
    }

    public void HighlightCerebellum()
    {
        cerebellumAnimator.SetTrigger("Highlight");
    }
}
