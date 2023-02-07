using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SceneChange(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
        Time.timeScale = 1.0f;
    }
    
    //public void GoToMainMenu()
    //{
    //    MainMenuController.Instance.mode5points = false;
    //    //SaveGameData.Save_GameData(MainMenuController.Instance);
    //    SceneManager.LoadScene(0);
    //    Time.timeScale = 1.0f;
    //}
}
