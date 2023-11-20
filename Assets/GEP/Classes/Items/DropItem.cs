using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropItem : MonoBehaviour
{
    public GameObject item;
    public GameObject player;
    public Inventory inventory;

    public void dropItem()
    {
        if(inventory.blueCount > 0)
        {
            inventory.blueCount--;
            inventory.blueText.text = inventory.blueCount.ToString();
            Instantiate(item, player.transform.position + transform.forward + new Vector3(0, 2, 0), Quaternion.identity);
        }
        else
        {

        }
    }
}
