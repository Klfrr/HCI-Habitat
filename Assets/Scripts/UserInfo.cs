using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
// Place in all scenes!!

[CreateAssetMenu(fileName = "UserHabit", menuName = "ScriptableObjects/UserInfo", order = 1)]
public class UserInfo : ScriptableObject
{
    [SerializeField]
    public string habitString;

    [SerializeField]
    public int lastHour;

    [SerializeField]
    public int lastMinute;

    [SerializeField]
    public int lastSecond;
}
