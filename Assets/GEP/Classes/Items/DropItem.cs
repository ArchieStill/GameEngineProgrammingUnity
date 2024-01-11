using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropItem : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject blueItem;
    public AudioClip blueDropSound;
    public GameObject redItem;
    public AudioClip redDropSound;
    public GameObject greenItem;
    public AudioClip greenDropSound;
    public GameObject yellowItem;
    public AudioClip yellowDropSound;
    public GameObject purpleItem;
    public AudioClip purpleDropSound;

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
                    inventory.blueHB.text = inventory.blueCount.ToString();
                    Instantiate(blueItem, player.transform.position + transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
                    audioSource.PlayOneShot(blueDropSound, 0.5f);
                    if (inventory.blueCount == 0)
                        inventory.pickupOrder--;
                }
                break;
            case ItemColour.RED:
                if (inventory.redCount > 0)
                {
                    inventory.redCount--;
                    inventory.redText.text = "x " + inventory.redCount.ToString();
                    inventory.redHB.text = inventory.redCount.ToString();
                    Instantiate(redItem, player.transform.position + transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
                    audioSource.PlayOneShot(redDropSound, 0.5f);
                    if (inventory.redCount == 0)
                        inventory.pickupOrder--;
                }
                break;
            case ItemColour.GREEN:
                if (inventory.greenCount > 0)
                {
                    inventory.greenCount--;
                    inventory.greenText.text = "x " + inventory.greenCount.ToString();
                    inventory.greenHB.text = inventory.greenCount.ToString();
                    Instantiate(greenItem, player.transform.position + transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
                    audioSource.PlayOneShot(greenDropSound, 0.5f);
                    if (inventory.greenCount == 0)
                        inventory.pickupOrder--;
                }
                break;
            case ItemColour.YELLOW:
                if (inventory.yellowCount > 0)
                {
                    inventory.yellowCount--;
                    inventory.yellowText.text = "x " + inventory.yellowCount.ToString();
                    inventory.yellowHB.text = inventory.yellowCount.ToString();
                    Instantiate(yellowItem, player.transform.position + transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
                    audioSource.PlayOneShot(yellowDropSound, 0.5f);
                    if (inventory.yellowCount == 0)
                        inventory.pickupOrder--;
                }
                break;
            case ItemColour.PURPLE:
                if (inventory.purpleCount > 0)
                {
                    inventory.purpleCount--;
                    inventory.purpleText.text = "x " + inventory.purpleCount.ToString();
                    inventory.purpleHB.text = inventory.purpleCount.ToString();
                    Instantiate(purpleItem, player.transform.position + transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
                    audioSource.PlayOneShot(purpleDropSound, 0.5f);
                    if (inventory.purpleCount == 0)
                        inventory.pickupOrder--;
                }
                break;
            default: 
                break;
        }
    }
}

[Serializable] public enum ItemColour {BLUE =  1, RED = 2, GREEN = 3, YELLOW = 4, PURPLE = 5}