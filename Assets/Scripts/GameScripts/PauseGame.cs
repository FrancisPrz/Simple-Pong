using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pausePanel;
    void Awake() => pausePanel.SetActive(false);

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            OpenPause();
    }
    public void OpenPause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ClosePause()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
