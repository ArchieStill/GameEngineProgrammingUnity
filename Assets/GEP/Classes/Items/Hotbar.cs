using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotbar : MonoBehaviour
{
    public GameObject blueArrow;
    public GameObject redArrow;
    public GameObject greenArrow;
    public GameObject yellowArrow;

    private int selected_colour = 1;

    public void HotbarSwitch()
    {
        if (selected_colour == 1)
        {
            FindObjectOfType<DropItem>().dropItem(id: 1);
        }
        else if (selected_colour == 2)
        {
            FindObjectOfType<DropItem>().dropItem(id: 2);
        }
        else if (selected_colour == 3)
        {
            FindObjectOfType<DropItem>().dropItem(id: 3);
        }
        else if (selected_colour == 4)
        {
            FindObjectOfType<DropItem>().dropItem(id: 4);
        }
    }

    public void blueSelected()
    {
        selected_colour = 1;
        blueArrow.SetActive(true);
        redArrow.SetActive(false);
        greenArrow.SetActive(false);
        yellowArrow.SetActive(false);
    }
    public void redSelected()
    {
        selected_colour = 2;
        blueArrow.SetActive(false);
        redArrow.SetActive(true);
        greenArrow.SetActive(false);
        yellowArrow.SetActive(false);
    }
    public void greenSelected()
    {
        selected_colour = 3;
        blueArrow.SetActive(false);
        redArrow.SetActive(false);
        greenArrow.SetActive(true);
        yellowArrow.SetActive(false);
    }
    public void yellowSelected()
    {
        selected_colour = 4;
        blueArrow.SetActive(false);
        redArrow.SetActive(false);
        greenArrow.SetActive(false);
        yellowArrow.SetActive(true);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}