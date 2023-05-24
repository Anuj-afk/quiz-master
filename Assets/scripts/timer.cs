using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool Isansweringquestion = false;
    public float fillFraction;
    public bool loadNextQuestion;

    float timerValue;
    void Update()
    {
        UpDateTimer();
    }
    private void UpDateTimer()
    {
        timerValue -= Time.deltaTime;
        if(Isansweringquestion == true)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else if(timerValue <= 0)
            {
                Isansweringquestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else if (Isansweringquestion == false)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            if (timerValue <= 0)
            {
                Isansweringquestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
            
        }
   
        Debug.Log(Isansweringquestion + ":" + timerValue + "=" + fillFraction);
    }
    public void cancelTimer()
    {
        timerValue = 0;
    }
}
