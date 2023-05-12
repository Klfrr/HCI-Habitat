using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public UserInfo savedInfo;

    public void LoadScene(string sceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }

    public void LoadHabitat()
    {
        switch(savedInfo.habitat)
        {
            case 1:
                SceneManager.LoadScene("Habitat 1");
                break;
            case 2:
                SceneManager.LoadScene("Habitat 2");
                break;
            case 3:
                SceneManager.LoadScene("Habitat 3");
                break;
            default:
                SceneManager.LoadScene("OpeningScene");
                break;
        }
    }
}