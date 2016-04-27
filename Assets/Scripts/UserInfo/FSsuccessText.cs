﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FSsuccessText : MonoBehaviour {

    Text text;
    UserClass user = new UserClass();

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = "GOOD JOB, " + UserClass.player.userId + "! LET'S BEGIN THE GAME!";
    }

}