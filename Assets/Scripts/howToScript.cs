using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class howToScript : MonoBehaviour
{
    public bool isPageOne;
    public bool isPageTwo;
    public bool isPageThree;
    public bool isPageFour;
    public bool isPageFive;
    public bool isPageSix;

    public GameObject pageOne;
    public GameObject pageTwo;
    public GameObject pageThree;
    public GameObject pageFour;
    public GameObject pageFive;
    public GameObject pageSix;

    GameObject[] leftArrow;
    GameObject[] rightArrow;





    void Start()
    {
        isPageOne = true;
        isPageTwo = false;
        isPageThree = false;
        isPageFour = false;
        isPageFive = false;

        leftArrow = GameObject.FindGameObjectsWithTag("leftArrow");
        rightArrow = GameObject.FindGameObjectsWithTag("rightArrow");

        HideLeftArrow();
    }


    public void StartGame()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void LeftArrow()
    {
        if (isPageTwo == true)
        {
            isPageOne = true;
            pageOne.SetActive(true);
            pageTwo.SetActive(false);
            isPageTwo = false;
            HideLeftArrow();

        }

        else if (isPageThree == true)
        {
            isPageTwo = true;
            pageTwo.SetActive(true);
            pageThree.SetActive(false);
            isPageThree = false;
        }

        else if (isPageFour == true)
        {
            isPageThree = true;
            pageThree.SetActive(true);
            pageFour.SetActive(false);
            isPageFour = false;
        }

        else if (isPageFive == true)
        {
            isPageFour = true;
            pageFour.SetActive(true);
            pageFive.SetActive(false);
            isPageFive = false;
        }

        else if (isPageSix == true)
        {
            isPageFive = true;
            pageFive.SetActive(true);
            pageSix.SetActive(false);
            isPageSix = false;
            ShowRightArrow();
        }


    }


    public void RightArrow()
    {
        if (isPageOne == true)
        {
            isPageTwo = true;
            pageTwo.SetActive(true);
            pageOne.SetActive(false);
            isPageOne = false;
            ShowLeftArrow();
        }

        else if (isPageTwo == true)
        {
            isPageThree = true;
            pageThree.SetActive(true);
            pageTwo.SetActive(false);
            isPageTwo = false;
        }

        else if (isPageThree == true)
        {
            isPageFour = true;
            pageFour.SetActive(true);
            pageThree.SetActive(false);
            isPageThree = false;
        }

        else if (isPageFour == true)
        {
            isPageFive = true;
            pageFive.SetActive(true);
            pageFour.SetActive(false);
            isPageFour = false;           
        }

        else if (isPageFive == true)
        {
            isPageSix = true;
            pageSix.SetActive(true);
            pageFive.SetActive(false);
            isPageFive = false;
            HideRightArrow();
        }
    }

    public void HideLeftArrow()
    {
        foreach (GameObject g in leftArrow)
        {
            g.SetActive(false);
        }
    }

    public void ShowLeftArrow()
    {
        foreach (GameObject g in leftArrow)
        {
            g.SetActive(true);
        }
    }

    public void HideRightArrow()
    {
        foreach (GameObject g in rightArrow)
        {
            g.SetActive(false);
        }
    }

    public void ShowRightArrow()
    {
        foreach (GameObject g in rightArrow)
        {
            g.SetActive(true);
        }
    }


}