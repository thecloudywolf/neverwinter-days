using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Need this for calling UI scripts

public class Manager : MonoBehaviour
{
    [SerializeField]
    Transform UIPanel;

    [SerializeField]
    Text timeText;

    bool isPaused;
    void Start()
    {
        UIPanel.gameObject.SetActive(false);
        isPaused = false;
    }
    void Update()
    {
        timeText.text = "Time Since Startup: " + Time.timeSinceLevelLoad;
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
            Pause();
        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused)
            UnPause();

    }
    public void Pause()
    {
        isPaused = true;
        UIPanel.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
    public void UnPause()
    {
        isPaused = false;
        UIPanel.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Restart()
    {
        Application.LoadLevel(0);
    }

}