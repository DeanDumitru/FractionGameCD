using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    public GameObject Barrier;
    public int check;

   // public GameObject CheckpointPosition;
/*
    void OnTriggerEnter(Collider other)
    {
        if (
        {
            Checking();
        }
    }
*/
      void Update () {

	    if (OnTrigger.Count == check)
        {
            Destroy(Barrier);
            OnTrigger.Count = 0;
        }
      
	}
}
