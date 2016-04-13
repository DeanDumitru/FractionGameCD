using UnityEngine;
using System.Collections;

public class IncreaseGravity : MonoBehaviour {

	public float value;
	// Use this for initialization
	void Start () {
        Physics.gravity = new Vector3(0, value, 0);
	}
}
