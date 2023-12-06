using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotbar : MonoBehaviour
{
    public GameObject blueSelect;
    public GameObject redSelect;
    public GameObject greenSelect;
    public GameObject yellowSelect;

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
        blueSelect.SetActive(true);
        redSelect.SetActive(false);
        greenSelect.SetActive(false);
        yellowSelect.SetActive(false);
    }
    public void redSelected()
    {
        selected_colour = 2;
        blueSelect.SetActive(false);
        redSelect.SetActive(true);
        greenSelect.SetActive(false);
        yellowSelect.SetActive(false);
    }
    public void greenSelected()
    {
        selected_colour = 3;
        blueSelect.SetActive(false);
        redSelect.SetActive(false);
        greenSelect.SetActive(true);
        yellowSelect.SetActive(false);
    }
    public void yellowSelected()
    {
        selected_colour = 4;
        blueSelect.SetActive(false);
        redSelect.SetActive(false);
        greenSelect.SetActive(false);
        yellowSelect.SetActive(true);
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
