using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickMythic : MonoBehaviour
{
    public UserInfo savedData;

    // This script allows the saving of the user's choice of Mythic
    public void pickOuroboros()
    {
        savedData.habitat = 1;
    }

    public void pickCerberus()
    {
        savedData.habitat = 2;
    }

    public void pickSphynx()
    {
        savedData.habitat = 3;
    }
}
