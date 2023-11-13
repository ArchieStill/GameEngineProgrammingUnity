using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropItem : MonoBehaviour
{
    public GameObject item;
    public GameObject player;
    private Vector3 facingDirection;

    public void dropItem()
    {
        Instantiate(item, facingDirection, Quaternion.identity);
    }

    /// start by getting direction player's facing, create vector that normalises that direction and add to position
    /// https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
}
