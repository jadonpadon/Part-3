using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public List<Villager> availableVillagers;

    public TMPro.TextMeshProUGUI currentSelection;
    public static Villager SelectedVillager { get; private set; }

    public void SetSelectedVillager(int index)
    {

        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = availableVillagers[index];
        SelectedVillager.Selected(true);
    }

    private void Update()
    {
        if(SelectedVillager != null)
        {
            currentSelection.text = SelectedVillager.GetType().ToString();
        }
    }
}
