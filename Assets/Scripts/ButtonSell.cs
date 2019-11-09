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
    // Start is called before the first frame update
    void Start()
    {
        // rubbish = GameObject.FindGameObjectWithTag("Rubbish");
        textEstimate = textEstimateComponent.GetComponent<Text>();
        textFish = textFishComponent.GetComponent<Text>();
        textFish2 = textFishComponent2.GetComponent<Text>();
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonSell1()
    {
        float money = float.Parse(textFish.text) + float.Parse(textEstimate.text);
        textEstimate.text = "" + money;
        
        textFish.text = "" + 0;
        controller.numberfish = 0;
        controller.curEstimate = money;
    }
    public void ButtonSell2()
    {
        float money = float.Parse(textFish2.text) + float.Parse(textEstimate.text);
        textEstimate.text = "" + money;
        textFish2.text = "" + 0;
        controller.numberfish2 = 0;
        controller.curEstimate = money;
    }
}
