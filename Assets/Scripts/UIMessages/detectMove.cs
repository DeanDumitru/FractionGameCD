﻿using UnityEngine;
using System.Collections;

public class detectMove : MonoBehaviour
{
    public GameObject TextToHide;
    public GameObject Player;
    Rigidbody rig;


	// Use this for initialization
	void Start ()
    {
        rig = Player.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            TextToHide.SetActive(false);
    }
}
