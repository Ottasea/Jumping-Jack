using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayCycleScript : MonoBehaviour
{

    public Sprite day;

    public Sprite dawn;

    public Sprite dusk;

    public Sprite night;

    public bool isDay = false;

    public bool isDusk = false;

    public bool isNight = false;

    public bool isDawn = false;

    public float dayTime;

    public float nightTime;

    public float duskTime;

    public float dawnTime;

    public float startTime = 40f;



    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = day;

        dayTime = startTime;

        isDay = true;

    }

    // Update is called once per frame
    void Update()
    {
        DayCycle();
        DuskCycle();
        NightCycle();
        DawnCycle();
    }

    void DayCycle()
    {
        if (dayTime <= 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = dusk;
            isDusk = true;
            isDay = false;
            dayTime = startTime;
        }

        else if (dayTime > 0 && isDay == true)
        {
            dayTime -= Time.deltaTime;
        }
    }

    void DuskCycle()
    {
        if (duskTime <= 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = night;
            isNight = true;
            isDusk = false;
            duskTime = startTime;
        }

        else if (duskTime > 0 && isDusk == true)
        {
            duskTime -= Time.deltaTime;
        }
    }

    void NightCycle()
    {
        if (nightTime <= 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = dawn;
            isDawn = true;
            isNight = false;
            nightTime = startTime;
        }

        else if (nightTime > 0 && isNight == true)
        {
            nightTime -= Time.deltaTime;
        }
    }

    void DawnCycle()
    {
        if (dawnTime <= 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = day;
            isDay = true;
            isDawn = false;
            dawnTime = startTime;
        }

        else if (dawnTime > 0 && isDawn == true)
        {
            dawnTime -= Time.deltaTime;
        }
    }

}
