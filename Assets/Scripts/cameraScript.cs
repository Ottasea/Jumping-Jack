using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Transform player;

    public Transform stalk1;

    public Transform stalk2;

    public Transform sky1;

    public Transform sky2;
    
    private float sizeStalk;
    private float sizeSky;

    void Start()
    {
        sizeStalk = stalk1.GetComponent<BoxCollider2D>().size.y;
        sizeSky = sky1.GetComponent<BoxCollider2D>().size.y;
    }


    // Update is called once per frame
    void LateUpdate() //If the player has vertically ascended beyond the camera, move the camera to keep up with the player
    {
        if (player.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = newPos;

            MoveStalk();
            MoveSky();
       
        }
    }

    void MoveStalk()
    {
        if (transform.position.y >= stalk2.position.y)
        {
            stalk1.position = new Vector3(stalk1.position.x, stalk2.position.y + sizeStalk, stalk1.position.z);
            SwitchBG();
        }
    }

    void MoveSky()
    {
        if (transform.position.y >= sky2.position.y)
        {
            sky1.position = new Vector3(sky1.position.x, sky2.position.y + sizeSky, sky1.position.z);
            SwitchSky();
        }
    }
    
    
    void SwitchBG()
    {
        Transform temp = stalk1;
        stalk1 = stalk2;
        stalk2 = temp;
    }

    void SwitchSky()
    {
        Transform temp = sky1;
        sky1 = sky2;
        sky2 = temp;
    }
}
