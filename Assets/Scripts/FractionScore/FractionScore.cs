﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FractionScore : MonoBehaviour {

    public int FractionValue = 0;
    public GameObject UICog;
    public AudioClip pick;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FractionManager.score += FractionValue;
            UICog.SetActive(false);
            AudioSource.PlayClipAtPoint(pick, UICog.transform.position);
        }
    }
}
