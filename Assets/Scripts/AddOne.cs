using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddOne : MonoBehaviour
{
    public Text numberStreak;
    public int number = 0;

    public void ButtonClicked()
    {
        number++;
        numberStreak.text = number.ToString();
    }
}
