using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    
    [SerializeField] private GameObject scoreText;

    private void Start()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score : " + score;
    }
}
