using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Victory_5points : MonoBehaviour
{
    public GameObject victoryPanel;
    public Transform canvasTransform;

    private static Victory_5points instance; 

    public static Victory_5points Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Victory_5points>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
    }

    public void Victory5pointsGame()
    {
        Instantiate(victoryPanel,canvasTransform);
    }
}
