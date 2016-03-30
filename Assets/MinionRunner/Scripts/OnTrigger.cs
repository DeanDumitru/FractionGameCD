using UnityEngine;
using System.Collections;

public class OnTrigger : MonoBehaviour {

    void OnTriggerEnter()
    {
       Counting.Count++;
    }
}
