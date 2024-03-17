using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Variables to manage timer functionality
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    // Flags to control timer behavior
    public bool loadNextQuestion;
    public bool isAnsweringQuestion = true;
    public float fillFraction;

    // Internal timer value
    float timerValue;

    // Update is called once per frame
    void Update()
    {
        // Update the timer logic
        UpdateTimer();
    }

    // Method to cancel the timer
    public void CancelTimer()
    {
        // Reset the timer value
        timerValue = 0;
    }

    // Method to update the timer logic
    void UpdateTimer()
    {
        // Decrement timer value based on deltaTime
        timerValue -= Time.deltaTime;

        // Check if currently answering a question
        if (isAnsweringQuestion)
        {
            // Update fill fraction if time is remaining
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            // Switch to showing correct answer if time is up
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        // Otherwise, manage showing the correct answer
        else
        {
            // Update fill fraction if time is remaining
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            // Switch back to answering questions if time is up
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
}
