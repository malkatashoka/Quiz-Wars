using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    // Variables to hold question and answer data
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    // Getter method for retrieving the question text
    public string GetQuestion()
    {
        return question;
    }

    // Getter method for retrieving the index of the correct answer
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    // Getter method for retrieving individual answer options
    public string GetAnswer(int index)
    {
        return answers[index];
    }
}
