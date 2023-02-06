using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 7f;
    public bool isPlayer1;
    float yBound = 2.8f;

    void Update()
    {
        float movement;

        if (isPlayer1)
            movement = Input.GetAxisRaw("Vertical");
        else
            movement = Input.GetAxisRaw("Vertical2");

        Vector2 playerPosition = transform.position;
        playerPosition.y = Mathf.Clamp(playerPosition.y + movement * speed * Time.deltaTime, -yBound, yBound);
        transform.position = playerPosition;
    }
}
