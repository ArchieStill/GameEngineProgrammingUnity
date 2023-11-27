using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenItem : MonoBehaviour, IPickupable
{
    Inventory inventory;

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    public void Pickup()
    {
        Destroy(gameObject);
        inventory.GreenItemPickup();
    }
}
