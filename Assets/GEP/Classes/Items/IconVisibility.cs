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

    void Update()
    {
        BlueCheck();
        RedCheck();
        GreenCheck();
        YellowCheck();
        PurpleCheck();
    }

    public void BlueCheck()
    {
        if (inventory.blueCount > 0)
        {
            foreach (GameObject blue in blueIcons)
            {
                blue.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject blue in blueIcons)
            {
                blue.SetActive(false);
            }
        }
    }
    public void RedCheck()
    {
        if (inventory.redCount > 0)
        {
            foreach (GameObject red in redIcons)
            {
                red.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject red in redIcons)
            {
                red.SetActive(false);
            }
        }
    }
    public void GreenCheck()
    {
        if (inventory.greenCount > 0)
        {
            foreach (GameObject green in greenIcons)
            {
                green.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject green in greenIcons)
            {
                green.SetActive(false);
            }
        }
    }
    public void YellowCheck()
    {
        if (inventory.yellowCount > 0)
        {
            foreach (GameObject yellow in yellowIcons)
            {
                yellow.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject yellow in yellowIcons)
            {
                yellow.SetActive(false);
            }
        }
    }
    public void PurpleCheck()
    {
        if (inventory.purpleCount > 0)
        {
            foreach (GameObject purple in purpleIcons)
            {
                purple.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject purple in purpleIcons)
            {
                purple.SetActive(false);
            }
        }
    }
}
