using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadZoneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<playerScript>().alive = false;
            Time.timeScale = 0;
        }

        if (other.gameObject.tag == "food" || other.gameObject.tag == "goose")
        {
            Destroy(other.gameObject);
        }

  
    }
}
