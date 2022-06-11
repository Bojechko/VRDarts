using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeSore : MonoBehaviour
{
    private int _score = 0;

    [SerializeField] private TextMeshPro scoreText;

    private void Start()
    {
        Target.AddScore += AddScore;
    }

    private void Update()
    {
        scoreText.text = "Score " + _score.ToString();
    }

    private void AddScore()
    {
        _score++;
    }
}
