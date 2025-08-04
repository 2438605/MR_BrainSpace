using Yarn.Unity;
using UnityEngine;

public class Yarncommands : MonoBehaviour
{
    public DialogueRunner DialogueRunner;
    public GameObject highlight_left, highlight_right, highlight_cerebellum, highlight_eyes, highlight_redpart, highlight_lowerbrain, highlight_center;

    public Yarncommands yarncommands;

    [YarnCommand("highlight_left")]
    public void Highlightleft()
    {
        highlight_left.SetActive(true);
    }

    [YarnCommand("Highlightright")]

    public void Highlightright()
    {
        highlight_right.SetActive(true);
    }

    [YarnCommand("highlight_cerebellum")]

    public void HighlightCerebellum()
    {
        highlight_cerebellum.SetActive(true);
    }

    [YarnCommand("highlight_eyes")]

    public void Highlighteyes()
    {
        highlight_eyes.SetActive(true);
    }

    [YarnCommand("highlight_redpart")]

    public void highlightredpart()
    {
        highlight_redpart.SetActive(true);
    }

    [YarnCommand("highlight_lowerbrain")]

    public void highlightlowerbrain()
    {
        highlight_lowerbrain.SetActive(true);
    }

    [YarnCommand("highlight_center")]

    public void highlightcentre()
    {
        highlight_center.SetActive(true);
    }

}
