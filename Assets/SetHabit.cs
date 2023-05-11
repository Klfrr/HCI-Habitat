using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHabit : MonoBehaviour
{
    public Text habit_input;
    public InputField input_box;

   public void setHabitName()
    {
        habit_input.text = input_box.text;

    }
}
