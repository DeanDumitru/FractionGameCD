﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FractionManager : MonoBehaviour
{
    public static int score;
    public int denominator; 
    public int StartingCogPart;    
    Text text;                    

    void Awake()
    {
        text = GetComponent<Text>();
        score = StartingCogPart;
    }

    void Update()
    {
        if (score == 0)
            text.text = "Fraction: " + "?/" + denominator;
        else text.text = "Fraction: " + score + "/" + denominator;
    }
}