using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropItem : MonoBehaviour
{
    public GameObject blueItem;
    public GameObject redItem;
    public GameObject greenItem;
    public GameObject yellowItem;

    public GameObject player;
    public Inventory inventory;

    public void dropItem(int id)
    {
        ItemColour colour = (ItemColour)id;

        switch (colour)
        {
            case ItemColour.BLUE:
                if (inventory.blueCount > 0)
                {
                    inventory.blueCount--;
                    inventory.blueText.text = "x " + inventory.blueCount.ToString();
                    Instantiate(blueItem, player.transform.position + transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
                }
                break;
            case ItemColour.RED:
                if (inventory.redCount > 0)
                {
                    inventory.redCount--;
                    inventory.redText.text = "x " + inventory.redCount.ToString();
                    Instantiate(redItem, player.transform.position + transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
                }
                break;
            case ItemColour.GREEN:
                if (inventory.greenCount > 0)
                {
                    inventory.greenCount--;
                    inventory.greenText.text = "x " + inventory.greenCount.ToString();
                    Instantiate(greenItem, player.transform.position + transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
                }
                break;
            case ItemColour.YELLOW:
                if (inventory.yellowCount > 0)
                {
                    inventory.yellowCount--;
                    inventory.yellowText.text = "x " + inventory.yellowCount.ToString();
                    Instantiate(yellowItem, player.transform.position + transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
                }
                break;
            default: 
                break;
        }
    }
}

[Serializable] public enum ItemColour {BLUE =  1, RED = 2, GREEN = 3, YELLOW = 4}