using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    // Variables to track correct answers and questions seen
    int correctAnswers = 0;
    int questionsSeen = 0;

    // Getter method for retrieving the number of correct answers
    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    // Method to increment the count of correct answers
    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    // Getter method for retrieving the number of questions seen
    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }

    // Method to increment the count of questions seen
    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    // Method to calculate the score based on correct answers and questions seen
    public int CalculateScore()
    {
        // Ensure that the score is calculated as an integer
        // RoundToInt is used to round the score to the nearest whole number
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);
    }
}
