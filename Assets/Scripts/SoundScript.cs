using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public GameController player;
    public AudioClip gameAudio, gameOverAudio;
    public AudioSource ad;
    bool gameOver ;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = true;
        player = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        gameAudio = Resources.Load<AudioClip>("Twirly_Tops");
        gameOverAudio = Resources.Load<AudioClip>("gameover");
        ad = this.GetComponent<AudioSource>();
        
               
    }
    private void Update()
    {
        if(player.curEstimate<=0 && gameOver==true){
                ad.clip = gameOverAudio;
                ad.PlayOneShot(gameOverAudio, .2f);
            gameOver = false;
                //end play sound dead
        }
    }
}
