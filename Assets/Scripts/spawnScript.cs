using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{

    public GameObject[] spawnThis;

    private float startTimer;

    private float elapsedTime;

    private int rand;

    public float minTime;
    public float maxTime;


    // Start is called before the first frame update
    void Start()
    {

        startTimer = Random.Range(minTime, maxTime);
        elapsedTime = startTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (elapsedTime <= 0)
        {
            rand = Random.Range(0, spawnThis.Length);
            Instantiate(spawnThis[rand], transform.position, Quaternion.identity);
            startTimer = Random.Range(minTime, maxTime);
            elapsedTime = startTimer;
        }
        else
        {
            elapsedTime -= Time.deltaTime;
        }
    }
           
       
}
