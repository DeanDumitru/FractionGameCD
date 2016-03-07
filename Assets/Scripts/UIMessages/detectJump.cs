using UnityEngine;
using System.Collections;

public class detectJump : MonoBehaviour
{

    public GameObject TextToHide;
    public GameObject Player;
    Rigidbody rig;


    // Use this for initialization
    void Start()
    {
        rig = Player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TextToHide.SetActive(false);
    }
}
