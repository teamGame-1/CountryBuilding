using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float maxEstimate = 100f;
    public float curEstimate;

    public float money;

    Text textEstimate;
    Text textFish;
    float timeDelay;
    float nextTime;
    Estimate estimate;

    public float numberfish = 0f;
    int estimates;
    public GameObject textEstimateComponent;

    Text moneyText;
    public GameObject textMoneyComponent;

    public GameObject restartButton;
    Button restartBtn;

    public GameObject useMoneyButton;
    Button useMoneyBtn;

    public GameObject gameOverUI;
    public GameObject panel;

    public GameObject textFishComponent;
    float FishUp = 0;

    // Start is called before the first frame update
    void Start()
    {

        textEstimate = textEstimateComponent.GetComponent<Text>();
        textFish = textFishComponent.GetComponent<Text>();
        textEstimate.text = "" + maxEstimate;
        curEstimate = maxEstimate;

        moneyText = textMoneyComponent.GetComponent<Text>();
        

        timeDelay = 0.75f;

        nextTime = Time.time;

        restartBtn = restartButton.GetComponent<Button>();
        restartBtn.onClick.AddListener(() => restart());

        useMoneyBtn = useMoneyButton.GetComponent<Button>();
        useMoneyBtn.onClick.AddListener(() => useMoney());

        gameOverUI.SetActive(false);
        panel.SetActive(true);

        money = 0f;

    }

    void FixedUpdate()
    {
        checkTime();
        checkGameOver();
        if(curEstimate >= 100)
        {

            money += curEstimate - 100;
            curEstimate = 100;
            
            
        }
        moneyText.text = "money: " + money + " $";
    }

    void checkTime()
    {
        if (Time.time > nextTime)
        {
            FishUp += 0.005f;
            curEstimate--;
            numberfish = numberfish + numberfish * FishUp + 1;
            textFish.text = "" + (int)numberfish;
            nextTime = Time.time + timeDelay;
            textEstimate.text = "" + (int)curEstimate;
        }
    }

    void checkGameOver()
    {
        if (curEstimate <= 0)
        {
            textEstimate.text = "0";
            gameOverUI.SetActive(true);
            Time.timeScale = 0;
            panel.SetActive(false);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    void useMoney()
    {
        if(money > 0)
        {
            float heal = maxEstimate - curEstimate;
            if(money >= heal)
            {
                money -= heal;
                curEstimate += heal;
            }
            else
            {
                curEstimate += money;
                money = 0;

            }
        }
        
    }
}
