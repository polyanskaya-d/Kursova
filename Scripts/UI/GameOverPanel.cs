﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private UIController _uiController;

    private void OnEnable()
    {
        AudioManager.Play(AudioClipName.GameOver);

        Time.timeScale = 0;
        _scoreText.text = "Score: " + _uiController.Score;
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
    }
}
