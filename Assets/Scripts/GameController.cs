using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float maxEstimate = 100f;
    public float curEstimate;



    Text textEstimate;
    Text textFish;
    float timeDelay;
    float nextTime;
    Estimate estimate;

    public float numberfish = 0f;
    int estimates;
    public GameObject textEstimateComponent;
    public GameObject textFishComponent;
    // Start is called before the first frame update
    void Start()
    {

        textEstimate = textEstimateComponent.GetComponent<Text>();
        textFish = textFishComponent.GetComponent<Text>();
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
            numberfish = numberfish + numberfish * 0.05f + 1;
            textFish.text = "" + (int)numberfish;
            nextTime = Time.time + timeDelay;
            textEstimate.text = "" + (int)curEstimate;
        }
    }
}
