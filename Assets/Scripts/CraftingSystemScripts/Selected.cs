//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Selected : MonoBehaviour
{
    [SerializeField] GameObject selectionRing;
    [Space]
    //item/recipe stuff
    [SerializeField] Image icon;
    [SerializeField] GameObject iconObject;
    [SerializeField] TextMeshProUGUI reagentName;
    [SerializeField] Button removeButton;
    [SerializeField] GameObject removeButtonObject;

    [SerializeField] Button Reagent1;
    [SerializeField] Button Reagent2;
    [SerializeField] Button Catalyst;

    public List<Item> items;

    public Item item;

    public bool isSelected = false;

    private void Start()
    {
        removeButton.onClick.AddListener(delegate
        {
            RemoveItem(item);
        });
    }

    public void Selection()
    {
        //you can click on it to select it, click again to unselect it.
        isSelected = selectionRing.activeSelf;
        selectionRing.SetActive(!isSelected);
        isSelected = selectionRing.activeSelf;
    }

    public bool AddItem(Item newItem)
    {
        if (items.Count < 1)
        {
            item = newItem;

            items.Add(item);

            icon.sprite = item.icon;
            iconObject.SetActive(true);
            reagentName.text = item.name;

            removeButtonObject.SetActive(true);
            return true;
        }
        return false;
    }


    public void RemoveItem(Item item)
    {

        items.Remove(item);
        Inventory.instance.Add(item);
        iconObject.SetActive(false);
        removeButtonObject.SetActive(false);
        reagentName.text = default;
    }

    public void ClearSlot()
    {
        items.Clear();
        iconObject.SetActive(false);
        removeButtonObject.SetActive(false);
        reagentName.text = default;
    }
}
