using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour {
    float[] grades = new float[5];
    // Start is called before the first frame update
    void Start() {
        float total = 0;
        string gradesString = "";

        for (var x = 0; x < grades.Length; x++) {
            grades[x] = Random.Range(0f, 100f);

            if (gradesString != "") {
                gradesString += ", ";
            }

            gradesString += grades[x];
            total += grades[x];
        }

        Debug.Log("Grades: " + gradesString);
        Debug.Log("Average: " + (total / grades.Length));
    }

    // Update is called once per frame
    void Update() {
        
    }
}
