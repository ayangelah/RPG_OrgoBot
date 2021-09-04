using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HazardousWasteDiscard : Interactable
{
    [SerializeField] GameObject inventory;
    [SerializeField] Animator animator;
    //public bool canRemove = false;
    public InventorySlot[] inventorySlotScripts;

    public override void Interact()
    {
        base.Interact();
        ThrowAway();
    }

    void ThrowAway()
    {
        //animate waste bin.
        animator.SetBool("bool", true);
        
        //remove button is interactable
        inventory.SetActive(true);
        //hintbot message ("you can now discard things in the waste bin")
        foreach (InventorySlot inventorySlotScript in inventorySlotScripts)
        {
            inventorySlotScript.ActivateDiscard();
        }
    }

    public override void OnDefocused()
    {
        //canRemove = false;
        base.OnDefocused();
        //animate waste bin
        animator.SetBool("bool", false);
        //remove button isnt interactable anymore
        inventory.SetActive(false);
        foreach (InventorySlot inventorySlotScript in inventorySlotScripts)
        {
                inventorySlotScript.DeactivateDiscard();
        }
    }
}
