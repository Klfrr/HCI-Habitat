using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
// Place in all scenes!!

//Kalista: This script allows use of a scriptable object that saves the data for our game.
[CreateAssetMenu(fileName = "UserHabit", menuName = "ScriptableObjects/UserInfo", order = 1)]
public class UserInfo : ScriptableObject
{
    //Save user's habit
    [SerializeField]
    public string habitString;

    // Save Hour they last checked in
    [SerializeField]
    public int lastHour;

    // Save minute they last checked in
    [SerializeField]
    public int lastMinute;

    // Save second they last checked in
    [SerializeField]
    public int lastSecond;

    // Save Habitat and mythic user picked
    [SerializeField]
    public int habitat;
}
