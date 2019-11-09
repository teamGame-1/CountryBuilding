using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSell : MonoBehaviour
{
    Text textEstimate;
    Text textFish;
    Text textFish2;
    public GameObject textEstimateComponent;
    public GameObject textFishComponent;
    public GameObject textFishComponent2;
    GameController controller;

    void Start()
    {

        textEstimate = textEstimateComponent.GetComponent<Text>();
        textFish = textFishComponent.GetComponent<Text>();
        textFish2 = textFishComponent2.GetComponent<Text>();
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }


    public void ButtonSell1()
    {
        /*float money = float.Parse(textFish.text) + float.Parse(textEstimate.text);
        textEstimate.text = "" + money;
        
        textFish.text = "" + 0;
        controller.numberfish = 0;
        controller.curEstimate = money;*/
        controller.money += float.Parse(textFish.text);
        textFish.text = "" + 0;
        controller.numberfish = 0;
    }
    public void ButtonSell2()
    {
        controller.money += float.Parse(textFish2.text);
        textFish2.text = "" + 0;
        controller.numberfish2 = 0;
    }
}
