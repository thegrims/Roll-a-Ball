using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour {
    public Image im;
    // Use this for initialization
    public void ChangeToScene(int scenetochangeto)
    {
        for (int i=0; i<10; i++)
        {
            Debug.Log("blah");
             im.GetComponent<CanvasRenderer>().SetAlpha(i/10);
        }
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
