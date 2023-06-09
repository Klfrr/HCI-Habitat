using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Abida Mim

// Based on which buttons are pushed, UI elements are toggled on and off
public class AddHabit : MonoBehaviour
{
    [SerializeField]
    public GameObject AddHabitUI;

    [SerializeField]
    public GameObject MenuUI;

    public void AddHabitScreenClose()
    {
        AddHabitUI.SetActive(false);
    }

    public void AddHabitScreenOpen()
    {
        AddHabitUI.SetActive(true);
    }

    public void MenuOpen()
    {
        MenuUI.SetActive(true);
    }

    public void MenuClose()
    {
        MenuUI.SetActive(false);
    }
}
