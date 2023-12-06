using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StateManager : MonoBehaviour
{
    bool isPlayer;
    public bool IsPlayer { get =>  isPlayer; }

    public GameObject UIInventory;
    public GameObject UIHotbar;

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
            UIHotbar.SetActive(true);
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            UIInventory.SetActive(true);
            UIHotbar.SetActive(false);
            UnityEngine.Cursor.lockState = CursorLockMode.None;
        }
    }
}
