using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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


    public GameObject restartButton;
    Button restartBtn;

    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        textEstimate = textEstimateComponent.GetComponent<Text>();
        textEstimate.text = ""+maxEstimate;
        curEstimate = maxEstimate;
        
        timeDelay = 1f;
        nextTime = Time.time;

        restartBtn = restartButton.GetComponent<Button>();
        restartBtn.onClick.AddListener(() => restart());

        gameOverUI.SetActive(false);

    }

    
    
    void FixedUpdate()
    {
        checkTime();
        checkGameOver();
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

    void checkGameOver()
    {
        if (curEstimate <= 0)
        {
            textEstimate.text = "0";
            gameOverUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
