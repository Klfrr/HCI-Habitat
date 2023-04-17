using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MythicScript : MonoBehaviour
{
    // Variables from 0 - 1
    public float happiness;
    public float hunger;
    public float thirst;

    // 
    public int points = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkTime()
    {

    }

    public void addHappiness(float num)
    {
        happiness += num;
    }

    void removeHappiness(float num)
    {
        happiness -= num;
    }

    public void addHunger(float num)
    {
        hunger += num;
    }

    void removeHunger(float num)
    {
        hunger -= num;
    }

    public void addThirst(float num)
    {
        thirst += num;
    }

    void removeThirst(float num)
    {
        thirst -= num;
    }

}
