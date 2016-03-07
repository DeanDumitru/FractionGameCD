using UnityEngine;
using System.Collections;

public class IncreaseGravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Physics.gravity = new Vector3(0, -55, 0);
	}
}
