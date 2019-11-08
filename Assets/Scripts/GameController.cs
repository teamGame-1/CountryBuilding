using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float maxEstimate = 100f;
    public float curEstimate;

    Text textEstimate;
    float timeDelay;
    float nextTime;
    Estimate estimate;
    int estimates;
    public GameObject textEstimateComponent;

    // Start is called before the first frame update
    void Start()
    {
        textEstimate = textEstimateComponent.GetComponent<Text>();
        textEstimate.text = ""+maxEstimate;
        curEstimate = maxEstimate;
        timeDelay = 1f;
        nextTime = Time.time;
    }

    
    
    void FixedUpdate()
    {
        checkTime();
    }

    void checkTime()
    {
        if(Time.time > nextTime)
        {
            curEstimate--;
            nextTime = Time.time + timeDelay;
            textEstimate.text = "" + curEstimate;
        }
    }
}
