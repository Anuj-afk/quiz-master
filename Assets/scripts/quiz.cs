using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questiontext;
    [SerializeField] QuestionSo question;
    [SerializeField] GameObject[] answerButtons;
    int CorrectAnswerIndex;
    [SerializeField] Sprite DefaultAnswerSprite;
    [SerializeField] Sprite CorrectAnswerSprite;
    void Start()
    {
        GetNextQuestion();
    }

    private void DisplayQuestion()
    {
        questiontext.text = question.GetQuestion();
        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

    public void OnAnswerSelected(int Index)
    {
        if (Index == question.GetCorrectAnswer())
        {
            questiontext.text = "correct";
            Image buttonImage = answerButtons[Index].GetComponent<Image>();
            buttonImage.sprite = CorrectAnswerSprite;
        }
        else
        {
            questiontext.text = "you have got the answer wrong. The correct ans was " + question.GetAnswer(question.GetCorrectAnswer());
            Image buttonImage = answerButtons[question.GetCorrectAnswer()].GetComponent<Image>();
            buttonImage.sprite = CorrectAnswerSprite;
        }
        SetButtonState(false);
    }

    private void SetButtonState(bool state)
    {
        for (int i = 0; i < answerButtons.Length;i++)
        {
            Button button = answerButtons[i].GetComponent<Button>();
            button.interactable = state;
        }
    }
    private void GetNextQuestion()
    {
        SetButtonState(true);
        DisplayQuestion();
        SetStartSprite();
    }
    private void SetStartSprite()
    {
        for(int i = 0; i < answerButtons.Length;i++)
        {
            Image buttonImage = answerButtons[i].GetComponent<Image>();
            buttonImage.sprite = DefaultAnswerSprite;
        }
    }
}
