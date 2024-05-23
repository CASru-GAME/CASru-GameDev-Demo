using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionStageClear : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            gameManager.gameClear();
        }
    }
}
