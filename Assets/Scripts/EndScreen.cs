using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        // Find the ScoreKeeper object in the scene
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        // Display the final score
        ShowFinalScore();
    }

    // Display the final score on the end screen
    public void ShowFinalScore()
    {
        // Display the final score text with a congratulatory message
        finalScoreText.text = $"Congratulations!\n" +
            $"You got {scoreKeeper.CalculateScore()}/100 points.";
    }
}
