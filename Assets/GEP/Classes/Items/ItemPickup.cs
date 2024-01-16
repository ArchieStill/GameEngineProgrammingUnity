using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour, IPickupable
{
    [SerializeField] Inventory inventory;

    void Start()
    {
        if (inventory == null)
            inventory = FindObjectOfType<Inventory>();
    }

    public void Pickup()
    {
        if (gameObject.tag == "Blue")
            inventory.BlueItemPickup();

        else if (gameObject.tag == "Red")
            inventory.RedItemPickup();

        else if (gameObject.tag == "Green")
            inventory.GreenItemPickup();

        else if (gameObject.tag == "Yellow")
            inventory.YellowItemPickup();

        else if (gameObject.tag == "Purple")
            inventory.PurpleItemPickup();

        else if (gameObject.tag == "Orange")
            inventory.OrangeItemPickup();

        if (inventory.pickupOrder <= 4)
            Destroy(gameObject);
    }
}
