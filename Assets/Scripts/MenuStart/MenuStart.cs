using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuStart : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject screen;
    public bool pause = false;
    // Start is called before the first frame update
    void Start()
    {
        screen.SetActive(true);
        pauseUI.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetButtonDown("Pause"))
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pause = !pause;
            }
            if (pause)
            {
                screen.SetActive(false);
                pauseUI.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                screen.SetActive(true);
                pauseUI.SetActive(false);
                Time.timeScale = 1;
            }

    }
    public void tamdung()
    {
        pause = !pause;
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
