using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpUi : MonoBehaviour
{
    public GameController player;
    // Start is called before the first frame update
    Image health;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        health = this.GetComponent<Image>();
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        health.fillAmount = ((float)player.curEstimate / (float)player.maxEstimate);
    }

}

