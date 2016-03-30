using UnityEngine;
using System.Collections;

public class GameManager4 : MonoBehaviour {

    public int FinalFraction;
    public GameObject[] TextToShow;
    public GameObject oldText;
    public GameObject oldBackground;
    public GameObject newText;
    public GameObject newBackground;
    public GameObject button;

    private int index;

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
            TextToShow[index].SetActive(true);
            oldBackground.SetActive(false);
            oldText.SetActive(false);
            newBackground.SetActive(true);
            newText.SetActive(true);
        }
	}
}
