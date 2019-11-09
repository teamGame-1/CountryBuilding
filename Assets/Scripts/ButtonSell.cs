using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSell : MonoBehaviour
{
    Text textEstimate;
    Text textFish;
    public GameObject textEstimateComponent;
    public GameObject textFishComponent;
    GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        // rubbish = GameObject.FindGameObjectWithTag("Rubbish");
        textEstimate = textEstimateComponent.GetComponent<Text>();
        textFish = textFishComponent.GetComponent<Text>();
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonSellAll()
    {
        float money = float.Parse(textFish.text) + float.Parse(textEstimate.text);
        textEstimate.text = "" + money;
        textFish.text = "" + 0;
        controller.numberfish = 0;
        controller.curEstimate = money;
    }
    public void ButtonSellHalf()
    {
        float money = float.Parse(textFish.text) / 2 + float.Parse(textEstimate.text);
        textEstimate.text = "" + (int)money;
        textFish.text = "" + (int)float.Parse(textFish.text) / 2;
        controller.numberfish = (int)float.Parse(textFish.text) / 2;
        controller.curEstimate = (int)money + 1;
    }
}
