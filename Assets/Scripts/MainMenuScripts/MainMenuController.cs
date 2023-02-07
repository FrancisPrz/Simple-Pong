using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MainMenuController : MonoBehaviour
{
    public GameObject gameModeSelector;

    public bool mode5points;

    private static MainMenuController instance;

    public static MainMenuController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<MainMenuController>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
        gameModeSelector.SetActive(false);
        //GameData gameData = SaveGameData.Load_GameData();
        mode5points = false;
        SaveGameData.Save_GameData(this);

    }
    public void OpenModeSelector() => gameModeSelector.SetActive(true);
    public void CloseModeSelector() => gameModeSelector.SetActive(false);
    public void modePointsActivate()
    {
        mode5points = true;
        SaveGameData.Save_GameData(this);
    } 
}
