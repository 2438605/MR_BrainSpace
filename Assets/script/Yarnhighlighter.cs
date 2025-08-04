using Yarn.Unity;
using UnityEngine;

public class YarnHighlighter : MonoBehaviour
{
    public BrainPartHighlighter highlighter;

    [YarnCommand("highlight_left")]
    public void HighlightLeftCommand()
    {
        highlighter.HighlightLeft();
    }

    [YarnCommand("highlight_right")]
    public void HighlightRightCommand()
    {
        highlighter.HighlightRight();
    }

    [YarnCommand("highlight_cerebellum")]
    public void HighlightCerebellumCommand()
    {
        highlighter.HighlightCerebellum();
    }
}
