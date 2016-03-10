using UnityEngine;
using System.Collections;

public class OnTrigger : MonoBehaviour {

    public static int Count = 0;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet" && gameObject.tag == "Destination")
        {
            Count++;
        }   
    }
}
