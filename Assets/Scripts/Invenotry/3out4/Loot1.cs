using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Loot1 : MonoBehaviour {

    public Texture2D i1;
    public int fractionValue;
    public GameObject target;
    public GameObject text;
    public AudioClip pick;

    ItemClass1 itemObject = new ItemClass1();

    private Ray mouseRay;
    private RaycastHit rayHit;

    /*private Dictionary<int, string> lootDictionary = new Dictionary<int, string>()
    {
        {1, null}
    };*/
	
	void Start ()
    {
        
	}

	void Update ()
    {
        /*mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Input.GetButtonDown("Fire1"))
        {
            Physics.Raycast(mouseRay, out rayHit, 10);
            if (rayHit.collider.transform.tag == "PickUp")
            {
                //la fel ca mai sus ca sa le adaug la mine in inventory
                /////////////////////////
                InventoryGUI.InventoryNameDictionary[1] = itemObject.cog16.name;
                InventoryGUI.dictonaryAmounts[0] += 1;
                /////////////////////////

                FractionManager.score += fractionValue;
                target.SetActive(false);
            }
        }*/
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FractionManager.score += fractionValue;
            target.SetActive(false);
            text.SetActive(true);
            AudioSource.PlayClipAtPoint(pick, target.transform.position);

            //la fel ca mai sus ca sa le adaug la mine in inventory
            /////////////////////////
            if (fractionValue == 1)
            {
                itemObject.cog16.SetIcon(i1);
                InventoryGUI1.InventoryNameDictionary1[0] = itemObject.cog16.icon;
                InventoryGUI1.dictonaryAmounts1[0] += 1;
            }

            else if (fractionValue == 2)
            {
                itemObject.cog26.SetIcon(i1);
                InventoryGUI1.InventoryNameDictionary1[1] = itemObject.cog26.icon;
                InventoryGUI1.dictonaryAmounts1[1] += 1;
            }

            else if (fractionValue == 3)
            {
                itemObject.cog36.SetIcon(i1);
                InventoryGUI1.InventoryNameDictionary1[2] = itemObject.cog36.icon;
                InventoryGUI1.dictonaryAmounts1[2] += 1;
            }

            else if (fractionValue == 4)
            {
                itemObject.cog46.SetIcon(i1);
                InventoryGUI1.InventoryNameDictionary1[3] = itemObject.cog46.icon;
                InventoryGUI1.dictonaryAmounts1[3] += 1;
            }

            else if (fractionValue == 5)
            {
                itemObject.cog56.SetIcon(i1);
                InventoryGUI1.InventoryNameDictionary1[4] = itemObject.cog56.icon;
                InventoryGUI1.dictonaryAmounts1[4] += 1;
            }

            else if (fractionValue == 6)
            {
                itemObject.cog66.SetIcon(i1);
                InventoryGUI1.InventoryNameDictionary1[5] = itemObject.cog66.icon;
                InventoryGUI1.dictonaryAmounts1[5] += 1;
            }
            /////////////////////////
        }
    }

}
