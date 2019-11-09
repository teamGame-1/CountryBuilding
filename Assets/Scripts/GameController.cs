using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float maxEstimate = 100f;
    public float curEstimate;



    Text textEstimate;
    Text textFish;
    Text textFish2;
    float timeDelay;
    float nextTime;
    Estimate estimate;
    public float fishUp = 0.05f;
    public float numberfish = 0f;
    public float numberfish2 = 0f;
    int estimates;
    public GameObject textEstimateComponent;
    public GameObject textFishComponent;
    public GameObject textFishComponent2;

    // Start is called before the first frame update
    void Start()
    {
        textEstimate = textEstimateComponent.GetComponent<Text>();
        textFish = textFishComponent.GetComponent<Text>();
        textFish2 = textFishComponent2.GetComponent<Text>();
        textEstimate.text = "" + maxEstimate;
        curEstimate = maxEstimate;
        timeDelay = 0.75f;
        nextTime = Time.time;
    }

    void FixedUpdate()
    {
        checkTime();
    }

    void checkTime()
    {
        if (Time.time > nextTime)
        {
            curEstimate--;
            numberfish = numberfish + numberfish * fishUp+ 1;
            numberfish2 = numberfish2 + numberfish2 * fishUp+ 1;
            textFish.text = "" + (int)numberfish;
            textFish2.text = "" + (int)numberfish2;
            nextTime = Time.time + timeDelay;
            textEstimate.text = "" + (int)curEstimate;
        }
    }
}
