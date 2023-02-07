using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text player1_ScoreText;
    [SerializeField] TMP_Text player2_ScoreText;

    [SerializeField] Transform player1Transform;
    [SerializeField] Transform player2Transform;
    [SerializeField] Transform ballTransform;

    private int player1_Score = 0;
    private int player2_Score = 0;

    private static GameManager instance;

    GameData gameData;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;

        player1_ScoreText.text = "0";
        player2_ScoreText.text = "0";

        gameData = SaveGameData.Load_GameData();
    }

    public void Player1Score()
    {
        player1_Score++;
        player1_ScoreText.text = player1_Score.ToString();
        if (gameData.mode5points == true)
        {
            if (player1_Score == 5)
                Victory_5points.Instance.Victory5pointsGame();
        }
    }

    public void Player2Score()
    {
        player2_Score++;
        player2_ScoreText.text = player2_Score.ToString();
        if (gameData.mode5points == true)
        {
            if (player2_Score == 5)
                Victory_5points.Instance.Victory5pointsGame();
        }
    }

    public void Restar()
    {
        player1Transform.position = new Vector2(player1Transform.position.x, 0);
        player2Transform.position = new Vector2(player2Transform.position.x, 0);
        
        ballTransform.position = new Vector2(0,0);
    }
}
