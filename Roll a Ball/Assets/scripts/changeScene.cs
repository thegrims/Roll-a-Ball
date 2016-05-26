using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour {
    public Image panel;
    bool frameCheck = false;
    float time = 0;
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
    void Update()
    {
        if (frameCheck==true)
        {
            time += Time.deltaTime;
            Debug.Log(time);
            if (time >= .9f)
            {
                SceneManager.LoadScene("minigame2");
            }
        }
        
    }

    public void ChangeToScene(int scenetochangeto)
    {
        Debug.Log(time);
        panel.transform.Translate(0, 2000, 1);
        startGame();
        StartCoroutine(showTextFuntion());
        frameCheck = true;
        


    }
    void startGame()
    {
        Color colorToFadeTo;
        colorToFadeTo = new Color(1f, 1f, 1f, 1f);
        panel.CrossFadeColor(colorToFadeTo, .9f, true, true);
        
    }
}
