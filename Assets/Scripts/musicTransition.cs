using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicTransition : MonoBehaviour
{
    static bool AudioBegin = false;
    void Awake()
    {
        if (!AudioBegin)
        {
            GetComponent<AudioSource>().Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        if (Application.loadedLevelName == "MainLevel")
        {
            //GetComponent<AudioSource>().Stop();
            //AudioBegin = false;
            Destroy(gameObject);
        }
    }

}
