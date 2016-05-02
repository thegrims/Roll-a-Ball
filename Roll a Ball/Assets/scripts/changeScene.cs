using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changeScene : MonoBehaviour {
    public Button button;
    public Button button2;
    public Button button3;
    // Use this for initialization
    void Start ()
    {
	    for (int i=0; i<10; i++)
        {
            button.GetComponent<CanvasRenderer>().SetAlpha(0.1f*i);
            button2.GetComponent<CanvasRenderer>().SetAlpha(0.1f * i);
            button3.GetComponent<CanvasRenderer>().SetAlpha(0.1f * i);
        }
        
        //button.CrossFadeAlpha(1f, .1f, false);
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
