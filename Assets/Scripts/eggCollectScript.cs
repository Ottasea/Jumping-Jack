using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggCollectScript : MonoBehaviour
{
    public AudioClip eggCollect;
    
    public playerScript playerController;

    public GameObject effect;

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
        if (collision.gameObject.name.StartsWith("Jack") && playerController.eggFull == false)
        {
            AudioSource.PlayClipAtPoint(eggCollect, transform.position, 1.0F);
            playerController.eggTotal += 2;
            playerController.topScore += 50;
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }

        else if (collision.gameObject.name.StartsWith("Jack") && playerController.eggFull == true)
        {
            AudioSource.PlayClipAtPoint(eggCollect, transform.position, 1.0F);
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }

        if (collision.gameObject.name.StartsWith("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}
