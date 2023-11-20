using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueItem : MonoBehaviour, IPickupable
{
    [SerializeField] Inventory inventory;

    void Start()
    {
        if (inventory == null) inventory = FindObjectOfType<Inventory>();
    }

    public void Pickup()
    {
        Destroy(gameObject);
        inventory.BlueItemPickup();
    }
}
