using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public GameObject windownCloseGame;

    private void Awake() => windownCloseGame.SetActive(false);
    
    public void OpenCloseGame() => windownCloseGame.SetActive(true);

    public void CloseGame() => Application.Quit();

    public void CloseCloseGame() => windownCloseGame.SetActive(false);
}
