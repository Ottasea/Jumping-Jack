using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformScript : MonoBehaviour
{
    public float jumpForce = 10f;
    public bool brownLeaf = false;
    public bool stripedLeaf = false;
    public bool greenLeaf = false;
    
    
    SpriteRenderer sprite;
    Collider2D myCollider;
    destroyerScript myDestroyer;
    playerScript myPlayer;



    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        myCollider = GetComponent<Collider2D>();

        myDestroyer = GameObject.FindGameObjectWithTag("destroyer").GetComponent<destroyerScript>();
        myPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<playerScript>();
    }

    void Update()
    {
        if (transform.position.x < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        else
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.relativeVelocity.y <= 0) //If the collision is coming from above the platform, then proceed to the next step
        {
            Rigidbody2D rB = collision.collider.GetComponent<Rigidbody2D>();
            
            if (greenLeaf == true && myPlayer.superJack == false) //If the GameObject that has collided with the platform has a Rigidbody then add velocity towards the Y axis to the GameObject based on the jumpForce variable
                {
                    Vector2 velocity = rB.velocity;
                    velocity.y = jumpForce;
                    rB.velocity = velocity;
                }
            
            else if (greenLeaf == true && myPlayer.superJack == true) //If the GameObject that has collided with the platform has a Rigidbody then add velocity towards the Y axis to the GameObject based on the jumpForce variable
                {
                    Vector2 velocity = rB.velocity;
                    velocity.y = jumpForce * 2;
                    rB.velocity = velocity;
                }
            
            else if (brownLeaf == true && myPlayer.superJack == false) //if the GameObject is destructible, apply velocity but destroy the platform
                {
                    Vector2 velocity = rB.velocity;
                    velocity.y = jumpForce;
                    rB.velocity = velocity;
                    Destroy(gameObject);
                    Instantiate(myDestroyer.greenLeaf, new Vector2(Random.Range(-8f, 6.5f), transform.position.y + (myDestroyer.leafDistance + Random.Range(myDestroyer.minY, myDestroyer.maxY))), Quaternion.identity);
                }
            
            else if (brownLeaf == true && myPlayer.superJack == true) //if the GameObject is destructible, apply velocity but destroy the platform
                {
                    Vector2 velocity = rB.velocity;
                    velocity.y = jumpForce * 2;
                    rB.velocity = velocity;
                    Destroy(gameObject);
                    Instantiate(myDestroyer.greenLeaf, new Vector2(Random.Range(-8f, 6.5f), transform.position.y + (myDestroyer.leafDistance + Random.Range(myDestroyer.minY, myDestroyer.maxY))), Quaternion.identity);
                }
            
            else if (stripedLeaf == true && myPlayer.superJack == false)
                {
                    //myCollider.enabled = !myCollider.enabled;
                    Vector2 velocity = rB.velocity;
                    velocity.y = jumpForce;
                    rB.velocity = velocity;
                }
            
            else if (stripedLeaf == true && myPlayer.superJack == true)
                {
                    //myCollider.enabled = !myCollider.enabled;
                    Vector2 velocity = rB.velocity;
                    velocity.y = jumpForce * 2;
                    rB.velocity = velocity;
                }

        }
    }
}
