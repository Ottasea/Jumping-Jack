using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicSwitch : MonoBehaviour
{
    public AudioSource myAudio;

    public AudioClip bgMusic;
    public AudioClip superJackMusic;
    public AudioClip gameOverMusic;

    public playerScript player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerScript>();

        myAudio.clip = bgMusic;
        myAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.alive == false)
        {
            if (myAudio.clip == bgMusic)
            {
                myAudio.clip = gameOverMusic;
                myAudio.Play();
            }
        }

        if (player.superJack == true)
        {
            if (myAudio.clip == bgMusic)
            {
                myAudio.clip = superJackMusic;
                myAudio.Play();
                myAudio.volume = 0.5f;
            }
        }

        if (player.superJack == false)
        {
            if (myAudio.clip == superJackMusic)
            {
                myAudio.clip = bgMusic;
                myAudio.Play();
                myAudio.volume = 0.3f;
            }
        }
        
        
       

    }
}
