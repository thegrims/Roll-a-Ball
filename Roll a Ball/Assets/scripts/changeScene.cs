using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour {
    public Image im;
    // Use this for initialization
    void Start()
    {
    //    StartCoroutine(showTextFuntion());
    }
    IEnumerator showTextFuntion()
    {
        yield return new WaitForSeconds(3f);
    }
    public void ChangeToScene(int scenetochangeto)
    {
        for (int i=0; i<10; i++)
        {
            Debug.Log("blah");
             //im.GetComponent<CanvasRenderer>().SetAlpha(i/10);
             
            //panel.GetComponent<Image>().CrossFadeColor(Color.black, 2.0f, false);
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
