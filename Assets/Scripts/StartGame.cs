using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    Button startButton;
    public GameObject startButtonObject;

    Button exitButton;
    public GameObject exitButtonObject;

    Button tutorialButton;
    public GameObject tutorialsButtonObject;

    public GameObject tutorialTutorial;
    public GameObject startTutorial;

    void Start()
    {
        startButton = startButtonObject.GetComponent<Button>();
        startButton.onClick.AddListener(() => startClick());
        tutorialButton = tutorialsButtonObject.GetComponent<Button>();
        tutorialButton.onClick.AddListener(() => tutorialClick());
        exitButton = exitButtonObject.GetComponent<Button>();
        startButton.onClick.AddListener(() => exitClick());
        tutorialTutorial.SetActive(false);
        startTutorial.SetActive(true);
        startButtonObject.SetActive(false);
    }

    void startClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void tutorialClick()
    {
        tutorialsButtonObject.SetActive(false);
        exitButtonObject.SetActive(false);
        tutorialTutorial.SetActive(true);
        startTutorial.SetActive(false);
        startButtonObject.SetActive(true);
    }
    void exitClick()
    {
        Application.Quit();
    }
}