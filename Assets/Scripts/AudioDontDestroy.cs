using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// keeps volume outside of scene using DontDestroyOnLoad
public class AudioDontDestroy : MonoBehaviour
{

    private static AudioDontDestroy playing = null;
    public static AudioDontDestroy KeepPlaying
    {
        get { return playing; }
    }

    void Awake()
    {
        if (playing != null && playing != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            playing = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

} 
