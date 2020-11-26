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
    GameObject[] eggShake;
    GameObject[] gOScore;

    public Slider slider;

    public bool shakeEgg;

    public bool eggHide;

    public playerScript playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        pauseObjects = GameObject.FindGameObjectsWithTag("showOnPause");         
        finishObjects = GameObject.FindGameObjectsWithTag("showOnFinish");
        score = GameObject.FindGameObjectsWithTag("hideScore");
        eggBar = GameObject.FindGameObjectsWithTag("hideEggTotal");
        eggShake = GameObject.FindGameObjectsWithTag("hideEggShake");
        gOScore = GameObject.FindGameObjectsWithTag("gameOverScore");

        hideFinished();
        hidePaused();
        hideEggShake();
        hideGameoverScore();

        shakeEgg = false;
        eggHide = false;

        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<playerScript>();
    }

    // Update is called once per frame
    void Update()
    {

        EggBar();
        ShakeEgg();

        //uses the p button to pause and unpause the game
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1 && playerController.alive == true)
            {
                Time.timeScale = 0;
                eggHide = true;                
                showPaused();                
                hideScore();               
                
            }
            else if (Time.timeScale == 0 && playerController.alive == true)
            {
                eggHide = false;
                Time.timeScale = 1;
                hidePaused();
                showScore();                
            }
        }

        if (eggHide == true)
        {
            hideEggTotal();
        }

        else if (eggHide == false)
        {
            showEggTotal();
        }


        if (Time.timeScale == 0 && playerController.alive == false)
        {
            showFinished();
            hideEggTotal();
            hideEggShake();
            hideScore();
            showGameoverScore();
        }


        if (playerController.eggTotal == 5)
        {
            shakeEgg = true;
            eggHide = true;
        }

        else
        {
            shakeEgg = false;
            eggHide = false;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (shakeEgg == true)
            {
                shakeEgg = false;
            }

        }
    }

    
    public void EggBar()
    {
        slider.value = playerController.eggTotal;
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

    public void showGameoverScore()
    {
        foreach (GameObject g in gOScore)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void hideGameoverScore()
    {
        foreach (GameObject g in gOScore)
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

    public void hideEggShake()
    {
        foreach (GameObject g in eggShake)
        {
            g.SetActive(false);
        }
    }

    public void showEggShake()
    {
        foreach (GameObject g in eggShake)
        {
            g.SetActive(true);
        }
    }

    public void ShakeEgg()
    {

        if (shakeEgg == true)
        {
            showEggShake();
            hideEggTotal();
        }

        if (shakeEgg == false)
        {
            showEggTotal();
            hideEggShake();
        }
    }

    public void doExitGame()
    {
        Application.Quit();
    }
}
    
    
   


