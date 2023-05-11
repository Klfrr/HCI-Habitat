using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public UserInfo SavedData;

    public void LoadScene(string sceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
}