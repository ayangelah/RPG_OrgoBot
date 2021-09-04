using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;

    public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    void PickUp()
    {
        //Debug.Log("Picking up " + item.name);

        //add to inventory
        bool wasPickedUp = Inventory.instance.Add(item);

        if (wasPickedUp == true )
            Destroy(gameObject);
    }
}
