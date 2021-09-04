using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button infoButton;
    public Button removeButton;
    public Image infoSprite;
    [SerializeField] LabStation labStation;
    [SerializeField] Selected selectedReagent1;
    [SerializeField] Selected selectedReagent2;
    [SerializeField] Selected selectedCatalyst;

    [SerializeField] GameObject infoPanel;
    [SerializeField] GameObject inventory;

    //where the item specific data is referenced:
    [Space]
    [SerializeField] TextMeshProUGUI titleName;
    [SerializeField] TextMeshProUGUI functionalGroups;
    [SerializeField] TextMeshProUGUI properties;
    [SerializeField] Slider electronucleophilicity;
    [SerializeField] Slider stability;

    public Item item;
    [SerializeField] List<Item> items;

    public void AddItem (Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        infoButton.interactable = true;
        removeButton.image.enabled = true;
        //removeButton.interactable = false;
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        infoButton.interactable = false;
        //removeButton.interactable = false;
        removeButton.image.enabled = false;
    }

    public void OnRemoveButton()
    {
        Inventory.instance.Remove(item);
    }

    public void OnInfoButton()
    {
        if (item != null & !labStation.isCrafting)
        {
            //open up UI info panel about item.
            Info();
        }
    }

    //infoPanel code filling in the fields.
    private void Info()
    {
        infoPanel.SetActive(true);
        inventory.SetActive(false);

        infoSprite.sprite = item.icon;
        titleName.text = item.name;
        functionalGroups.text = item.functionalGroups;
        properties.text = item.properties;
        electronucleophilicity.value = item.electronucleophilicity;
        stability.value = item.stability;
    }


    //hazardous waste discard code

    public void ActivateDiscard()
    {
        Debug.Log("activated discard");
        removeButton.interactable = true;
    }

    public void DeactivateDiscard()
    {
        Debug.Log("Deactivated discard");
        removeButton.interactable = false;
    }

    //crafting panel stuff
    public void OnItemButton()
    {
        //slot one
        if (item != null & labStation.isCrafting & selectedReagent1.isSelected)
        {
            //clear inventory slot
            selectedReagent1.AddItem(item);
            Inventory.instance.Remove(item);
            Debug.Log("item clicked");
            //get the item in a reagent slot
        }

        //slot two
        if (item != null & labStation.isCrafting & selectedReagent2.isSelected)
        {
            //clear inventory slot
            selectedReagent2.AddItem(item);
            Inventory.instance.Remove(item);
            Debug.Log("item clicked");
            //get the item in a reagent slot
        }

        //slot three
        if (item != null & labStation.isCrafting & selectedCatalyst.isSelected)
        {
            //clear inventory slot
            selectedCatalyst.AddItem(item);
            Inventory.instance.Remove(item);
            Debug.Log("item clicked");
            //get the item in a reagent slot
        }
    }
}
