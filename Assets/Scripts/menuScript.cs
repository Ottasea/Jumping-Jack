﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Mainlevel");
    }

    public void HowTo()
    {
        SceneManager.LoadScene("HowTo");
    }

}
