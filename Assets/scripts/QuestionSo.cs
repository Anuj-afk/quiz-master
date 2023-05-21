using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "quiz question", fileName = "question")]
public class QuestionSo : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";


    public string GetQuestion()
    {
        return question;
    }
}
