using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Kalista: Mythic script handles 

public class MythicScript : MonoBehaviour
{
    // Variables from 0 - 1
    public float happiness = 1;
    public float hunger = 1;
    public float thirst = 1;

    // How much the stats should change
    public const float dHunger = 5.0f;
    public const float dHappiness = 5.0f;
    public const float dThirst = 5.0f;
    public Slider happinessBar;
    public Button happinessUp;
    public Button happinessDown;

    // tracks times the task is done
    public int points = 0;
    public int repetitions;

    //time variables
    public Text timeLabel;
    public Text dateLabel;
    public int hour;
    public int minutes;
    public int seconds;
    public int hourThreshold = 16;

    //ScriptableObject
    public UserInfo savedData;

    // Start is called before the first frame update
    void Start()
    {
        // happiness = savedData.happiness;
        happiness = 1;
        UpdateBar();
    }

    // Update is called once per frame
    // Updates the real time clock
    void Update()
    {
        dateLabel.text = DateTime.Now.ToLongDateString();

        hour = DateTime.Now.Hour;
        string fhours;
        string AMPM;
        if(hour > 12)
        {
            fhours = "0" + (hour%12).ToString(); 
            AMPM = " PM";
        }else{
            fhours = hour.ToString();
            AMPM = " AM";
        }

        minutes = DateTime.Now.Minute;
        string fminutes;
        if(minutes < 10)
        {
            fminutes = "0" + minutes.ToString();
        }else{
            fminutes = minutes.ToString();
        }
        seconds = DateTime.Now.Second;
        timeLabel.text = "" + fhours + ":" + fminutes + AMPM; //+ ":" + seconds;

        UpdateBar();
        //deathScenario(happiness);
    }

    // Updates the happiness bar for the mythic
    public void UpdateBar()
    {
        happinessBar.value = happiness;
    }

    // 12:00 last check in was at 8:00 am

    void checkTime()
    {
        Debug.Log("Time since last Check In: " + (savedData.lastHour - DateTime.Now.Hour).ToString());
        if((savedData.lastHour - DateTime.Now.Hour) < hourThreshold)
            Debug.Log("Less than Threshold " + hourThreshold.ToString());
        else
            Debug.Log("More than Threshold " + hourThreshold.ToString());
    }

    void setTime() //called on the button press
    {
        savedData.lastHour = hour;
        savedData.lastMinute = minutes;
        savedData.lastSecond = seconds;
    }
/*
    public IEnumerator Updatetime(bool active)
    {
        while(active)
            {
                
                yield return new WaitForSeconds(0.2f); 
            }
    }
*/
    public void addHappiness(float num = dHappiness)
    {
        happiness += num;
        deathScenario(happiness);
    }

    public void removeHappiness(float num = dHappiness)
    {
        happiness -= num;
        deathScenario(happiness);
    }

    public void addHunger(float num = dHunger)
    {
        hunger += num;
    }

    public void removeHunger(float num = dHunger)
    {
        hunger -= num;
    }

    public void addThirst(float num = dThirst)
    {
        thirst += num;
    }

    public void removeThirst(float num = dThirst)
    {
        thirst -= num;
    }

    // Move to Death Screen scene when the happiness is less than or equal to 0
    void deathScenario(float stat)
    {
        if(stat <= 0)
        {
            SceneManager.LoadScene("Death Screen");
        }
    }

    void releaseScenario(int growth)
    {
        if(growth == repetitions)
        {
            //give Player money
            
        }
    }

}
