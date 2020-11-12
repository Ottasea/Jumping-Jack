using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class playerScript : MonoBehaviour
{
    Rigidbody2D rB; //Rigidbody for the player

    //Player Movement\\
    float movement = 0f; 
    public float movementSpeed = 10f;
    private float moveInput;
    public bool alive;
    public float screenRight;
    public float screenLeft;
    
    
    //Super Jack\\
    public bool superJack = false;
    public float startTime = 5.0f;
    public float sJTimer;

    //Score Update\\
    public Text scoreText;
    public int eggTotal = 0;
    public float topScore = 0.0f;
    public float maxY;
    public float currentY;


    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        alive = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentY = transform.position.y;
        
        if (moveInput < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        
        else
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }


        if (currentY > maxY)
        {
            maxY = currentY;
            topScore++;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (eggTotal == 5)
            {
                superJack = true;
                sJTimer = startTime;
            }
            
        }

        SuperJack();


        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();
    }
    void FixedUpdate() //Applies the velocity required for the player to move in the direction they choose whilst bouncing on platforms
    {
            Vector2 velocity = rB.velocity;
            velocity.x = movement;
            rB.velocity = velocity;
            
            moveInput = Input.GetAxis("Horizontal");
            rB.velocity = new Vector2(moveInput * movementSpeed, rB.velocity.y);

        if (transform.position.x > screenRight)
        {
            transform.position = new Vector2(screenLeft, transform.position.y);
        }
        if (transform.position.x < screenLeft)
        {
            transform.position = new Vector2(screenRight, transform.position.y);
        }

    }

    void SuperJack()
    {
        if (superJack == true)
        {
            sJTimer -= Time.deltaTime;
        }

        if (sJTimer <= 0)
        {
            superJack = false;
        }
    }

}


