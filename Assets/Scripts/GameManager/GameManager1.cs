using UnityEngine;
using System.Collections;

public class GameManager1 : MonoBehaviour {

    public int FinalFraction;
    public GameObject Player;
    public GameObject OtherPlayer;
    public GameObject light1;
    public GameObject NextButton;
	public GameObject Inventory = null;
    public GameObject[] TextToShow;

    int index;

	// Use this for initialization
	void Start ()
    {
        index = Random.Range(0, TextToShow.Length);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(FractionManager.score == FinalFraction)
        {
            Player.SetActive(true);
            OtherPlayer.SetActive(false);
            TextToShow[index].SetActive(true);
            light1.SetActive(true);
            NextButton.SetActive(true);
			Inventory.SetActive (true);
        }
	}
}
