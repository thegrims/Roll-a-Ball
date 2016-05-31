using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Transition : MonoBehaviour {
    public GameObject Player;
    public GameObject pauseMenu;
    public GameObject gameUI;
    public Text winLoss;
    //public Image menuCanvas;
    bool setactive = false;
    // Use this for initialization
    void Start ()
    {
        //Player.GetComponent<playerController>().enabled = false;
        //script = GetComponent(playerController);
        //script.enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    //if (setactive==true)
        {
            //Color colorToFadeTo;
            //colorToFadeTo = new Color(1f, 1f, 1f, 1f);
            //menuCanvas.CrossFadeColor(colorToFadeTo, .9f, true, true);
        }
	}
    void FixedUpdate()
    {
        if (Player.GetComponent<playerController>().pickupCount == 4)
        {
            Player.GetComponent<playerController>().enabled = false;
            Player.GetComponent<playerController>().rb.velocity = new Vector3(0,0, 0);
            winLoss.text = "You Won";
            pauseMenu.SetActive(true);
            setactive = true;
            gameUI.SetActive(false);
        }
    }

    }
