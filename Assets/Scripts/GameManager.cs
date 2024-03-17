using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    EndScreen endScreen;

    void Awake()
    {
        // Find the Quiz and EndScreen objects in the scene
        quiz = FindObjectOfType<Quiz>();
        endScreen = FindObjectOfType<EndScreen>();
    }

    void Start()
    {
        // Activate the Quiz and deactivate the EndScreen at the start of the game
        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }

    void Update()
    {
        // Check if the quiz is complete
        if (quiz.isComplete)
        {
            // Deactivate the Quiz and activate the EndScreen
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            // Show the final score on the EndScreen
            endScreen.ShowFinalScore();
        }
    }

    // Method to reload the current scene, effectively replaying the level
    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
