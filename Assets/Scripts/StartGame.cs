using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public GameObject tutorialTutorial;
    public GameObject startTutorial;

    void Start()
    {
        tutorialTutorial.SetActive(false);
        startTutorial.SetActive(true);
    }

    public void startClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void tutorialClick()
    {
        tutorialTutorial.SetActive(true);
        startTutorial.SetActive(false);
    }
    public void exitClick()
    {
        Application.Quit();
    }
}