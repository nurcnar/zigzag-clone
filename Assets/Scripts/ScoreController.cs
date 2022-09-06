using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//yigituzunal@gmail.com

public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;
    private void Awake()
    {
        instance = this;
    }

    public TextMeshProUGUI scoreText;

    private int m_score;
    public int Score
    {
        get => m_score;
        set
        {
            m_score = value;
            scoreText.text = value.ToString();
        }
    }
}
