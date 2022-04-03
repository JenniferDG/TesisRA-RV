using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;

    // Update is called once per frame
    void Update()
    {

        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 6);
            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Según el modelo de Rutherford, en el núcleo hay:";
                QuestionDisplay.newA = "Protones y electrones";
                QuestionDisplay.newB = "Protones y neutrones";
                QuestionDisplay.newC = "Protones, solamente";
                actualAnswer = "B";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "En su modelo atómico, Thomson imaginó el atomo como una:";
                QuestionDisplay.newA = "Esfera";
                QuestionDisplay.newB = "Circunferencia";
                QuestionDisplay.newC = "Masa invisible";
                actualAnswer = "A";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Los electrones giran en ciertas órbitas permitidas";
                QuestionDisplay.newA = "Bohr";
                QuestionDisplay.newB = "Rutherford";
                QuestionDisplay.newC = "Thompson";
                actualAnswer = "A";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "La carga positiva se encuentra repartida por todo el átomo";
                QuestionDisplay.newA = "Bohr";
                QuestionDisplay.newB = "Rutherford";
                QuestionDisplay.newC = "Thompson";
                actualAnswer = "C";
            }

            if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Los electrones se encuentran incrustados en el átomo";
                QuestionDisplay.newA = "Bohr";
                QuestionDisplay.newB = "Thompson";
                QuestionDisplay.newC = "Galiard";
                actualAnswer = "B";
            }

            QuestionDisplay.pleaseUpdate = false;

        }
        
    }
}
