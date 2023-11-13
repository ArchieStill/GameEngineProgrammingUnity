using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StateManager : MonoBehaviour
{
    bool isPlayer;
    public bool IsPlayer { get =>  isPlayer; }

    public GameObject UIInventory;

    void Start()
    {
        isPlayer = true;
    }

    public void toggleIsPlayer()
    {
        isPlayer = !isPlayer;
        if (isPlayer) 
        {
            UIInventory.SetActive(false);
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            UIInventory.SetActive(true);
            UnityEngine.Cursor.lockState = CursorLockMode.None;
        }
    }
}
