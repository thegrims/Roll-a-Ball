using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour {
    public Image panel;
    
    // Use this for initialization
    void Start()
    {
        panel.GetComponent<CanvasRenderer>().SetAlpha(0);
            
    }
    IEnumerator showTextFuntion()
    {
        //Application.LoadLevel("minigame2");
        yield return new WaitForSeconds(3f);
    }
    public void ChangeToScene(int scenetochangeto)
    {
        panel.transform.Translate(0, 2000, 1);
        startGame();
        StartCoroutine(showTextFuntion());
        SceneManager.LoadScene("minigame2");
       


    }
    void startGame()
    {
        Color colorToFadeTo;
        colorToFadeTo = new Color(1f, 1f, 1f, 1f);
        panel.CrossFadeColor(colorToFadeTo, 1f, true, true);
        
    }
    // Update is called once per frame
    void Update ()
    {
	    
	}
}
