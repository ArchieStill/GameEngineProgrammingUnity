using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerCharacterInput : MonoBehaviour
{
    [Header("Character Input Values")]
    public Vector2 move;
    public Vector2 look;
    public bool jump;
    public bool sprint;
    public bool switchState;
    public bool dropItem;
    public bool bluePressed;

    [Header("Movement Settings")]
    public bool analogMovement;

    [Header("Mouse Cursor Settings")]
    public bool cursorLocked = true;
    public bool cursorInputForLook = true;

    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    public void OnLook(InputValue value)
    {
        if (cursorInputForLook)
        {
            LookInput(value.Get<Vector2>());
        }
    }

    public void OnJump(InputValue value)
    {
        JumpInput(value.isPressed);
    }

    public void OnSprint(InputValue value)
    {
        SprintInput(value.isPressed);
    }

    public void OnSwitchStates(InputValue value)
    {
        FindObjectOfType<StateManager>().toggleIsPlayer();
    }

    public void OnDrop(InputValue value)
    {
        FindObjectOfType<SelectItem>().DropByButton();
    }

    public void OnItem1()
    {
        if (FindObjectOfType<StateManager>().IsPlayer)
        {
            FindObjectOfType<SelectItem>().selectedSlot = 1;
            FindObjectOfType<SelectItem>().selectItem(1);
        }
    }
    public void OnItem2()
    {
        if (FindObjectOfType<StateManager>().IsPlayer)
        {
            FindObjectOfType<SelectItem>().selectedSlot = 2;
            FindObjectOfType<SelectItem>().selectItem(2);
        }
    }
    public void OnItem3()
    {
        if (FindObjectOfType<StateManager>().IsPlayer)
        {
            FindObjectOfType<SelectItem>().selectedSlot = 3;
            FindObjectOfType<SelectItem>().selectItem(3);
        }
    }
    public void OnItem4()
    {
        if (FindObjectOfType<StateManager>().IsPlayer)
        {
            FindObjectOfType<SelectItem>().selectedSlot = 4;
            FindObjectOfType<SelectItem>().selectItem(4);
        }
    }

    /*public void OnHBLeft()
    {
        if (FindObjectOfType<StateManager>().IsPlayer)
        {
            FindObjectOfType<SelectItem>().LastItem();
            FindObjectOfType<SelectItem>().selectItem(FindObjectOfType<SelectItem>().selectedSlot);
        }
    }
    public void OnHBRight()
    {
        if (FindObjectOfType<StateManager>().IsPlayer)
        {
            FindObjectOfType<SelectItem>().NextItem();
            FindObjectOfType<SelectItem>().selectItem(FindObjectOfType<SelectItem>().selectedSlot);
        }
    }
    public void OnIVLeft()
    {
        if (FindObjectOfType<StateManager>().IsPlayer == false)
        {
            FindObjectOfType<SelectItem>().LastItem();
            FindObjectOfType<SelectItem>().selectItem(FindObjectOfType<SelectItem>().selectedSlot);
        }
    }
    public void OnIVRight()
    {
        if (FindObjectOfType<StateManager>().IsPlayer == false)
        {
            FindObjectOfType<SelectItem>().NextItem();
            FindObjectOfType<SelectItem>().selectItem(FindObjectOfType<SelectItem>().selectedSlot);
        }
    }*/

    public void MoveInput(Vector2 newMoveDirection)
    {
        if (FindObjectOfType<StateManager>().IsPlayer)
            move = newMoveDirection;
    }

    public void LookInput(Vector2 newLookDirection)
    {
        if (FindObjectOfType<StateManager>().IsPlayer)
            look = newLookDirection;
    }

    public void JumpInput(bool newJumpState)
    {
        if (FindObjectOfType<StateManager>().IsPlayer)
            jump = newJumpState;
    }

    public void SprintInput(bool newSprintState)
    {
        if (FindObjectOfType<StateManager>().IsPlayer)
            sprint = newSprintState;
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        SetCursorState(cursorLocked);
    }

    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }
}
