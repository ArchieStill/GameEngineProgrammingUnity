using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconVisibility : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    public GameObject[] blueIcons;
    public GameObject[] redIcons;
    public GameObject[] greenIcons;
    public GameObject[] yellowIcons;
    public GameObject[] purpleIcons;
    public GameObject[] orangeIcons;

    void Update()
    {
        BlueCheck();
        RedCheck();
        GreenCheck();
        YellowCheck();
        PurpleCheck();
        OrangeCheck();
    }

    public void BlueCheck()
    {
        if (inventory.blueCount > 0)
        {
            foreach (GameObject icons in blueIcons)
            {
                icons.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject icons in blueIcons)
            {
                icons.SetActive(false);
            }
        }
    }
    public void RedCheck()
    {
        if (inventory.redCount > 0)
        {
            foreach (GameObject icons in redIcons)
            {
                icons.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject icons in redIcons)
            {
                icons.SetActive(false);
            }
        }
    }
    public void GreenCheck()
    {
        if (inventory.greenCount > 0)
        {
            foreach (GameObject icons in greenIcons)
            {
                icons.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject icons in greenIcons)
            {
                icons.SetActive(false);
            }
        }
    }
    public void YellowCheck()
    {
        if (inventory.yellowCount > 0)
        {
            foreach (GameObject icons in yellowIcons)
            {
                icons.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject icons in yellowIcons)
            {
                icons.SetActive(false);
            }
        }
    }
    public void PurpleCheck()
    {
        if (inventory.purpleCount > 0)
        {
            foreach (GameObject icons in purpleIcons)
            {
                icons.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject icons in purpleIcons)
            {
                icons.SetActive(false);
            }
        }
    }
    public void OrangeCheck()
    {
        if (inventory.orangeCount > 0)
        {
            foreach (GameObject icons in orangeIcons)
            {
                icons.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject icons in orangeIcons)
            {
                icons.SetActive(false);
            }
        }
    }
}
