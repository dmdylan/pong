using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;
    public AudioSource pointSound;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="Player1Racket" || collision.gameObject.name == "Player2Racket")
        {
            this.racketSound.Play();
        }
        else if(collision.gameObject.name=="TopSide" || collision.gameObject.name == "BottomSide")
        {
            this.wallSound.Play();
        }
        else
        {
            this.pointSound.Play();
        }
    }
}
