using UnityEngine;

public class DropdownManager : MonoBehaviour
{
    public GameObject[] dropdowns; // Assign all 5 dropdown GameObjects in the Inspector

    // Call this from each button click, passing the index of the dropdown
    private int currentOpen = -1;

    public void ToggleDropdown(int index)
    {
        for (int i = 0; i < dropdowns.Length; i++)
        {
            if (i == index)
            {
                bool shouldOpen = currentOpen != i;
                dropdowns[i].SetActive(shouldOpen);
                currentOpen = shouldOpen ? i : -1;
            }
            else
            {
                dropdowns[i].SetActive(false);
            }
        }
    }
}
