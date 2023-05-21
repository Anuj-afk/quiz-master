using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

[CreateAssetMenu(menuName = "quiz question", fileName = "question")]
public class QuestionSo : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];

    [SerializeField] [Range(0, 4)] int IndexAns;
    public string GetQuestion()
    {
        return question;
    }
    public int GetCorrectAnswer()
    {
        return IndexAns;
    }
    public string GetAnswer(int index)
    {
        return answers[index];
    }
}