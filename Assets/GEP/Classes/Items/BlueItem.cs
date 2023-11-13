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

    /// <summary>
    /// This is where you will want to add your own implementation for your own systems.
    /// </summary>
    public void Pickup()
    {
        Destroy(gameObject);
        inventory.BlueItemPickup();
    }
}