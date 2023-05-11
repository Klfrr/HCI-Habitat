using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHabit : MonoBehaviour
{
    [SerializeField]
    public GameObject AddHabitUI;

    public void AddHabitScreenClose()
    {
        AddHabitUI.SetActive(false);
    }

    public void AddHabitScreenOpen()
    {
        AddHabitUI.SetActive(true);
    }
}
