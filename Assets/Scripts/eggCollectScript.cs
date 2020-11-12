using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggCollectScript : MonoBehaviour
{
    public playerScript playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<playerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("Jack"))
        {
            Destroy(gameObject);
            playerController.eggTotal += 1;
            playerController.topScore += 50;

        }

        else if (collision.gameObject.name.StartsWith("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}
