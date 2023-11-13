using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject item;

    public void dropItem()
    {
        Instantiate(item, new Vector3(0, 1, 0), Quaternion.identity);
    }
}
