using UnityEngine;
using System.Collections;

public class MainMenuButton : MonoBehaviour {

	public void click()
    {
        //Application.LoadLevel("Menu");
        OnPause.isPause = false;
    }
}
