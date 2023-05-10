using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MythicScript : MonoBehaviour
{
    // Variables from 0 - 1
    public float happiness;
    public float hunger;
    public float thirst;

    // How much the stats should change
    public const float dHunger = 5.0f;
    public const float dHappiness = 5.0f;
    public const float dThirst = 5.0f;

    // 
    public int points = 0;
    public Text timeLabel;
    public Text dateLabel;
    public int repetitions;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Updatetime();
    }

    void checkTime()
    {
        /*
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy   HH:mm");
        string timeUS = System.DateTime.UtcNow.ToLocalTime().ToString("M/d/yy   hh:mm tt");
        largeText.text = time + "[breaktag]" + timeUS;
        */
    }

    public IEnumerator Updatetime()
    {
        while(true)
            {
                var today = System.DateTime.Now;
                dateLabel.text = today.ToString("MM-dd-yyyy");
                timeLabel.text = today.ToString("HH:mm");
                yield return new WaitForSeconds(0.2f); 
            }
    }

    public void addHappiness(float num = dHappiness)
    {
        happiness += num;
    }

    void removeHappiness(float num = dHappiness)
    {
        happiness -= num;
    }

    public void addHunger(float num = dHunger)
    {
        hunger += num;
    }

    void removeHunger(float num = dHunger)
    {
        hunger -= num;
    }

    public void addThirst(float num = dThirst)
    {
        thirst += num;
    }

    void removeThirst(float num = dThirst)
    {
        thirst -= num;
    }

    void deathScenario(float stat)
    {
        if(stat <= 0)
        {
            //move screen to death screen
        }
    }

    void releaseScenario(int growth)
    {
        if(growth == repetitions)
        {
            //give Player money
            //move screen to Catalog screen
        }
    }

}
