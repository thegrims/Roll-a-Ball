using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour {
    
    // Use this for initialization
    public void ChangeToScene(int scenetochangeto)
    {

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene(scenetochangeto, SceneManager.mode = LoadSceneMode.Single);
        //button.CrossFadeAlpha(1f, .1f, false);
        Application.LoadLevel("minigame2");
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
