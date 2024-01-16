using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StateManager : MonoBehaviour
{
    bool isPlayer;
    public bool IsPlayer { get =>  isPlayer; }

    public GameObject UIInventory;
    public AudioSource audioSource;
    public AudioClip open;
    public AudioClip close;
    public GameObject playerInstruct;
    public GameObject inventoryInstruct;
    public ItemText itemText;

    void Start()
    {
        isPlayer = true;
    }

    public void toggleIsPlayer()
    {
        isPlayer = !isPlayer;
        if (isPlayer) 
        {
            audioSource.PlayOneShot(close, 0.7f);
            UIInventory.SetActive(false);
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
            playerInstruct.SetActive(true);
            inventoryInstruct.SetActive(false);
        }
        else
        {
            audioSource.PlayOneShot(open, 0.7f);
            UIInventory.SetActive(true);
            UnityEngine.Cursor.lockState = CursorLockMode.None;
            playerInstruct.SetActive(false);
            inventoryInstruct.SetActive(true);
            itemText.blueText.SetActive(false);
            itemText.redText.SetActive(false);
            itemText.greenText.SetActive(false);
            itemText.yellowText.SetActive(false);
            itemText.purpleText.SetActive(false);
            itemText.orangeText.SetActive(false);
        }
    }
}
