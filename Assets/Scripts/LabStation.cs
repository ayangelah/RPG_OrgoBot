//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabStation : Interactable
{
    [SerializeField] GameObject inventory;
    [SerializeField] GameObject craftingPanel;
    [SerializeField] Button inventoryButton;
    [SerializeField] GameObject exitInventoryButton;
    public bool isCrafting = false;

    public override void Interact()
    {
        base.Interact();
        LabInteract();
    }

    void LabInteract()
    {
        isCrafting = true;
        //activate inventory
        inventory.SetActive(true);
        //activate crafing panel
        craftingPanel.SetActive(true);
        //deactivate inventory button
        inventoryButton.interactable = false;
        exitInventoryButton.SetActive(false);
    }

    public override void OnDefocused()
    {
        isCrafting = false;
        base.OnDefocused();
        inventoryButton.interactable = true;
        exitInventoryButton.SetActive(true);
        inventory.SetActive(false);
        craftingPanel.SetActive(false);

    }
}
