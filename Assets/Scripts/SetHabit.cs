using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Abida Mim
// when a user types in a habit, it appears on screen

public class SetHabit : MonoBehaviour
{
    public Text habit_output;
    public InputField input_box;

    public UserInfo savedData;

    public void setHabitName()
    {
        savedData.habitString = input_box.text;
        habit_output.text = savedData.habitString;

    }
}
