using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {
    public float speed;
    public float jumpSpeed;
    public int pickupCount = 0;
    private Rigidbody rb;
    bool jumping = false;
    public Text countText;
    public Text timeText;
    public Text timeText2;
    public Image star1;
    public Image star2;
    public Image star3;
    public Image star4;
    int platform = 0;
    float timer = 30;
    //public static bool winTrigger = false;

    void Start()
    {
        star1.GetComponent<CanvasRenderer>().SetAlpha(0.2f);
        star2.GetComponent<CanvasRenderer>().SetAlpha(0.2f);
        star3.GetComponent<CanvasRenderer>().SetAlpha(0.2f);
        star4.GetComponent<CanvasRenderer>().SetAlpha(0.2f);
        if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            platform = 1;
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            platform = 2;
        }
        //countText.GetComponent<CanvasRenderer>().SetAlpha(0.5f);
        SetCountText();
        rb = GetComponent<Rigidbody>();
    }
    void Update ()
    {
        //updates after every frame of movement
        
        timer -= Time.deltaTime; //Time.deltaTime will increase the value with 1 every second.
        timeText.text = Mathf.Round(timer).ToString();
        timeText2.text = Mathf.Round(timer).ToString();
        if (Input.GetKeyDown("space") && jumping == false)
        {
            {
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            }
            jumping = true;
        }
        
    }
    void FixedUpdate ()
    {
        //updates after every physics movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
        

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pick up"))
        {
            pickupCount++;
            SetCountText();
            other.gameObject.SetActive(false);
        }
    }
    void OnCollisionStay()
    {
        jumping = false;
    }
    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            //Debug.Log("test1");
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            }
            jumping = false;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            //Debug.Log("test1");
            /*if (Input.GetKeyDown("space"))
            {
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            }
            jumping = true;
        }
    }*/

    void SetCountText()
    {
        countText.text = "SCORE: " + pickupCount.ToString();
        if (pickupCount==1)
        {
            /*
            for (int i = 0; i < 100; i++)
            {
                Debug.Log("blah");
                star1.GetComponent<CanvasRenderer>().SetAlpha(i / 100);
                //panel.GetComponent<Image>().CrossFadeColor(Color.black, 2.0f, false);
            }*/
            Color colorToFadeTo;
            colorToFadeTo = new Color(1f, 1f, 1f, 1f);
            star1.CrossFadeColor(colorToFadeTo, 1f, true, true);
        }
        if (pickupCount == 2)
        { /*
            for (int i = 0; i < 100; i++)
            {
                Debug.Log("blah");
                star2.GetComponent<CanvasRenderer>().SetAlpha(i / 100);
                //panel.GetComponent<Image>().CrossFadeColor(Color.black, 2.0f, false);
            }*/
            Color colorToFadeTo;
            colorToFadeTo = new Color(1f, 1f, 1f, 1f);
            star2.CrossFadeColor(colorToFadeTo, 1f, true, true);
        }
        if (pickupCount == 3)
        {
            /*
            for (int i = 0; i < 100; i++)
            {
                Debug.Log("blah");
                star3.GetComponent<CanvasRenderer>().SetAlpha(i / 100);
                //panel.GetComponent<Image>().CrossFadeColor(Color.black, 2.0f, false);
            }*/
            Color colorToFadeTo;
            colorToFadeTo = new Color(1f, 1f, 1f, 1f);
            star3.CrossFadeColor(colorToFadeTo, 1f, true, true);
        }
        if (pickupCount == 4)
        {/*
            for (int i = 0; i < 100; i++)
            {
                Debug.Log("blah");
                star4.GetComponent<CanvasRenderer>().SetAlpha(i / 100);
                //panel.GetComponent<Image>().CrossFadeColor(Color.black, 2.0f, false);
            }*/
            Color colorToFadeTo;
            colorToFadeTo = new Color(1f, 1f, 1f, 1f);
            star4.CrossFadeColor(colorToFadeTo, 1f, true, true);
        }
        if (pickupCount >= 4)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //winText.text = "You Win!";
        }
    }
}


    
