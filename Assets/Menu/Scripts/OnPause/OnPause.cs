using UnityEngine;
using System.Collections;

public class OnPause : MonoBehaviour {

    public GameObject MenuToDisplay;
    public GameObject Character;
    public bool isPause = false;
    

	void Start ()
    {
        Cursor.visible = false;
        //MenuToDisplay.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
            if (isPause)
            {
                Time.timeScale = 0;
                Cursor.visible = true;
                MenuToDisplay.SetActive(true);
                Character.SetActive(false);
            }
            else if (isPause == false)
            {
                Time.timeScale = 1;
                Cursor.visible = false;
                MenuToDisplay.SetActive(false);
                Character.SetActive(true);
            }
        }
    }
}
