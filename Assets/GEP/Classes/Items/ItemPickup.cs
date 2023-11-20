using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour, IPickupable
{
    [SerializeField] Inventory inventory;

    public GameObject BlueItem;
    public GameObject RedItem;
    public GameObject GreenItem;
    public GameObject YellowItem;

    void Start()
    {
        if (inventory == null)
            inventory = FindObjectOfType<Inventory>();
    }

    public void Pickup()
    {
        Destroy(gameObject);
        if (gameObject == BlueItem)
        {
            inventory.BlueItemPickup();
        }
        else if (gameObject == RedItem)
        {
            inventory.RedItemPickup();
        }
        else if (gameObject == GreenItem)
        {
            inventory.GreenItemPickup();
        }
        else if (gameObject == YellowItem)
        {
            inventory.YellowItemPickup();
        }
    }
}
