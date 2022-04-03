using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAbackBlue; //Azul esperando
    public GameObject answerAbackGreen; //Verde es correcto
    public GameObject answerAbackRed; //Rojo es incorrecto

    public GameObject answerBbackBlue; //Azul esperando
    public GameObject answerBbackGreen; //Verde es correcto
    public GameObject answerBbackRed; //Rojo es incorrecto

    public GameObject answerCbackBlue; //Azul esperando
    public GameObject answerCbackGreen; //Verde es correcto
    public GameObject answerCbackRed; //Rojo es incorrecto


    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;

    public AudioSource correctFX;
    public AudioSource wrongFX;

    public GameObject currentScore;
    public int scoreValue;
    public int bestScore;
    public GameObject bestDisplay;

    public GameObject numQuestion;
    public int count_question;
    public GameObject question_text;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<Text>().text = "Best:" + bestScore;
    }

    void Update()
    {
        currentScore.GetComponent<Text>().text = "SCORE: " + scoreValue;
        numQuestion.GetComponent<Text>().text = "Question: " + count_question + "/5";
        if (count_question == 5){

            answerA.gameObject.SetActive(false);
            answerB.gameObject.SetActive(false);
            answerC.gameObject.SetActive(false);
            question_text.GetComponent<Text>().text = "Fin";

        }

    }

    public void AnswerA()
    {
        if (QuestionGenerate.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            count_question += 1;
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue = 0;
            count_question += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenerate.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            count_question += 1;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue = 0;
            count_question += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        if (QuestionGenerate.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            count_question += 1;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue = 0;
            count_question += 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<Text>().text = "BEST:" + scoreValue;
        }

        yield return new WaitForSeconds(1);

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;

        QuestionGenerate.displayingQuestion = false;
    }
}