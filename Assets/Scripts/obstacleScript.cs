using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleScript : MonoBehaviour
{
    public bool isFood = false;
    public bool isLGoose = false;
    public bool isRGoose = false;


    public float gooseWorth;
    
    public float speed = 10f;

    public playerScript playerController;


    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<playerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveFood();
        MoveGoose();
    }


    void MoveFood()
    {
        if (isFood == true)
        {
            transform.Translate(0, -1 * Time.deltaTime * speed, 0);
        }
    }

    void MoveGoose()
    {

        if (isLGoose == true)
        {
            transform.Translate(1 * Time.deltaTime * speed, 0, 0);
        }
        else if (isRGoose == true)
        {
            transform.Translate(-1 * Time.deltaTime * speed, 0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("Jack"))
        {
            if (playerController.eggTotal > 0 && !isFood && playerController.superJack == false)
            {
                playerController.eggTotal = 0;
                playerController.eggFull = false;
                Destroy(gameObject);
            }

            else if (playerController.eggTotal <= 0 && !isFood && playerController.superJack == false)
            {
                playerController.alive = false;
                Time.timeScale = 0;
            }

            else if (isFood == true && playerController.superJack == false)
            {
                playerController.alive = false;
                Time.timeScale = 0;
            }

            else
            {
                Destroy(gameObject);
            }


        }
    }


}
