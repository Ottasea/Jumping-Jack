using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warningScript : MonoBehaviour
{
    public bool leftWarn = false;
    public bool rightWarn = false;

    public float startWarning;
    public float warning;

    GameObject[] leftWarning;
    GameObject[] rightWarning;

    void Start()
    {
        leftWarning = GameObject.FindGameObjectsWithTag("warnLeft");
        rightWarning = GameObject.FindGameObjectsWithTag("warnRight");

        HideWarning();
    }

   

    // Update is called once per frame
    void Update()
    {
        if (warning <= 0)
        {
            HideWarning();
        }
        else
        {
            warning -= Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "food")
        {
            warning = startWarning;
            ShowWarning();
        }
    }

    void ShowWarning()
    {
        if (leftWarn == true)
        {
            foreach (GameObject g in leftWarning)
            {
                g.SetActive(true);
            }
        }

        else if (rightWarn == true)
        {
            foreach (GameObject g in rightWarning)
            {
                g.SetActive(true);
            }
        }
    }

    void HideWarning()
    {
        if (leftWarn == true)
        {
            foreach (GameObject g in leftWarning)
            {
                g.SetActive(false);
            }
        }

        else if (rightWarn == true)
        {
            foreach (GameObject g in rightWarning)
            {
                g.SetActive(false);
            }
        }
    }
}
