using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuStart : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject backgroundStart;
    public GameObject screen;
    public bool pause = false;
    bool carry = false;
    bool dung = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseUI.SetActive(false);
        backgroundStart.SetActive(true);
        screen.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetButtonDown("Pause"))
        if (carry)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pause = !pause;
            }
            if (pause)
            {
                pauseUI.SetActive(true);
                screen.SetActive(false);
                Time.timeScale = 0;
            }
            else
            {
                screen.SetActive(true);
                pauseUI.SetActive(false);
                Time.timeScale = 1;
            }
        }

    }
    public void start()
    {
        backgroundStart.SetActive(false);
        screen.SetActive(true);
        pause = false;
        carry = true;
    }
    public void tamdung()
    {
        pause = !pause;
        if (pause)
        {
            pauseUI.SetActive(true);
            screen.SetActive(false);
            Time.timeScale = 0;
        }
        else
        {
            screen.SetActive(true);
            pauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void resume()
    {
        pause = false;
    }
    public void restart()
    {
        pause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void quit()
    {
        Application.Quit();
    }
}
