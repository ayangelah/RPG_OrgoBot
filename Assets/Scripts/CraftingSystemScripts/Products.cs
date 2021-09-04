using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Products : MonoBehaviour
{
    public List<Item> items;
    public Item item;
    [SerializeField] TextMeshProUGUI productName;
    [SerializeField] Button slotButton;
    [SerializeField] Image icon;

    private void Start()
    {
        slotButton.onClick.AddListener(delegate
        {
            Remove(item);
        });
    }

    public void Add(Item newItem)
    {
        item = newItem;

        icon.enabled = true;
        items.Add(item);
        productName.text = item.name;

    }

    public void Remove(Item item)
    {
        Inventory.instance.Add(item);
        icon.enabled = false;
        items.Remove(item);
        productName.text = default;
    }
}
