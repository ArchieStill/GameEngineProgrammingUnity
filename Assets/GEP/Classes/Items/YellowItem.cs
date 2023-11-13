using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowItem : MonoBehaviour, IPickupable
{
    [SerializeField] Inventory inventory;

    void Start()
    {
        if (inventory == null) inventory = FindObjectOfType<Inventory>();
    }

    public void Pickup()
    {
        Destroy(gameObject);
        inventory.YellowItemPickup();
    }
}
