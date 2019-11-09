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
    Text textFish2;
    float timeDelay;
    float nextTime;
    Estimate estimate;
    public float fishUp = 0.05f;
    public float numberfish = 0f;
    public float numberfish2 = 0f;
    int estimates;
    public GameObject textEstimateComponent;


    Text moneyText;
    public GameObject textMoneyComponent;

    public GameObject restartButton;
    Button restartBtn;

    public GameObject useMoneyButton;
    Button useMoneyBtn;

    public GameObject gameOverUI;
   

    public GameObject textFishComponent; 
    public GameObject textFishComponent2;

    public float porpular;
    // Start is called before the first frame update
    void Start()
    {
        textEstimate = textEstimateComponent.GetComponent<Text>();
        textFish = textFishComponent.GetComponent<Text>();
        textFish2 = textFishComponent2.GetComponent<Text>();
        textEstimate.text = "" + maxEstimate;
        curEstimate = maxEstimate;

        moneyText = textMoneyComponent.GetComponent<Text>();

        porpular = 1f;

        timeDelay = 0.75f;
        nextTime = Time.time;

        restartBtn = restartButton.GetComponent<Button>();
        restartBtn.onClick.AddListener(() => restart());

        useMoneyBtn = useMoneyButton.GetComponent<Button>();
        useMoneyBtn.onClick.AddListener(() => useMoney());

        gameOverUI.SetActive(false);


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
        moneyText.text = "money: " + (int)money + " $";

    }

    void checkTime()
    {
        if (Time.time > nextTime)
        {
            curEstimate -= (1 + porpular * 0.1f);
            porpular++;
            numberfish = numberfish + numberfish * fishUp+ 1;
            numberfish2 = numberfish2 + numberfish2 * fishUp+ 1;
            textFish.text = "" + (int)numberfish;
            textFish2.text = "" + (int)numberfish2;
            nextTime = Time.time + timeDelay;
            textEstimate.text = "" + (int)curEstimate;
        }
    }

    void checkGameOver()
    {
        if (curEstimate <= 0)
        {
            textEstimate.text = "0";
            Time.timeScale = 0;
            gameOverUI.SetActive(true);
            useMoneyButton.SetActive(false);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        useMoneyButton.SetActive(true);
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
