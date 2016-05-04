using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour {
    
    // Use this for initialization
    public void ChangeToScene(int scenetochangeto)
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //button.CrossFadeAlpha(1f, .1f, false);
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
