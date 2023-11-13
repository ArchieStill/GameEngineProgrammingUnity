using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StateManager : MonoBehaviour
{
    bool isPlayer;
    public bool IsPlayer { get =>  isPlayer; }

    public GameObject UIBackground;
    public GameObject UIBase;
    public GameObject UITitle;

    void Start()
    {
        isPlayer = true;
    }

    public void toggleIsPlayer()
    {
        isPlayer = !isPlayer;
        if (isPlayer) 
        {
            UIBackground.SetActive(false);
            UIBase.SetActive(false);
            UITitle.SetActive(false);
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            UIBackground.SetActive(true);
            UIBase.SetActive(true);
            UITitle.SetActive(true);
            UnityEngine.Cursor.lockState = CursorLockMode.None;
        }
    }
}
