using UnityEngine;
using System.Collections;

public class detectInvetoryToggle : MonoBehaviour
{
    public GameObject oldText;
    public GameObject newText;

    // Update is called once per frame
    void Update()
    {
        if (InventoryGUI.InventoryStatus() || Input.GetKeyDown(KeyCode.I))
        {
            oldText.SetActive(false);
            newText.SetActive(true);
        }
	}
}
