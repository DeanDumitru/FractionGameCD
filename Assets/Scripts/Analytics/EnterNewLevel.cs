using UnityEngine;
using System.Collections;

public class EnterNewLevel : MonoBehaviour {

	public string levelName;

	void Start () {
		Analytics.gua.sendAppScreenHit(levelName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
