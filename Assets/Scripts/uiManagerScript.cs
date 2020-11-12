using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManagerScript : MonoBehaviour
{   
    GameObject[] finishObjects;
    GameObject[] pauseObjects;
    GameObject[] score;
    GameObject[] eggBar;

    public playerScript playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        pauseObjects = GameObject.FindGameObjectsWithTag("showOnPause");         
        finishObjects = GameObject.FindGameObjectsWithTag("showOnFinish");
        score = GameObject.FindGameObjectsWithTag("hideScore");
        eggBar = GameObject.FindGameObjectsWithTag("hideEggTotal");

        hideFinished();
        hidePaused();

        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<playerScript>();
    }

    // Update is called once per frame
    void Update()
    {

        EggBar();

        //uses the p button to pause and unpause the game
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1 && playerController.alive == true)
            {
                Time.timeScale = 0;
                showPaused();
                hideScore();
                hideEggTotal();
            }
            else if (Time.timeScale == 0 && playerController.alive == true)
            {
                Time.timeScale = 1;
                hidePaused();
                showScore();
                showEggTotal();
            }
        }


        if (Time.timeScale == 0 && playerController.alive == false)
        {
            showFinished();
            hideEggTotal();
        }

    }

    
    public void EggBar()
    {
       
    }

    public void Reload()
    {
        SceneManager.LoadScene("MainLevel");
    }

    //controls the pausing of the scene
    public void pauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    //shows objects with ShowOnPause tag
    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }


    public void showFinished()
    {
        foreach (GameObject g in finishObjects)
        {
            g.SetActive(true);
        }
    }

    public void hideFinished()
    {
        foreach (GameObject g in finishObjects)
        {
            g.SetActive(false);
        }
    }

    public void hideScore()
    {
        foreach (GameObject g in score)
        {
            g.SetActive(false);
        }
    }

    public void showScore()
    {
        foreach (GameObject g in score)
        {
            g.SetActive(true);
        }
    }

    public void hideEggTotal()
    {
        foreach (GameObject g in eggBar)
        {
            g.SetActive(false);
        }
    }

    public void showEggTotal()
    {
        foreach (GameObject g in eggBar)
        {
            g.SetActive(true);
        }
    }

    public void doExitGame()
    {
        Application.Quit();
    }
}
    
    
   


