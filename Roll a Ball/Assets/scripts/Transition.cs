using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {
    public GameObject Player;
    
    // Use this for initialization
    void Start ()
    {
        //Player.GetComponent<playerController>().enabled = false;
        //script = GetComponent(playerController);
        //script.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        if (Player.GetComponent<playerController>().pickupCount == 4)
        {
            Player.GetComponent<playerController>().enabled = false;
        }
    }

    }
