using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour {
    public float speed;
    public float jumpSpeed;
    private int pickupCount = 0;
    private Rigidbody rb;
    bool jumping = false;
    public Text countText;
    //public static bool winTrigger = false;

    void Start()
    {
        countText.GetComponent<CanvasRenderer>().SetAlpha(0.5f);
        SetCountText();
        rb = GetComponent<Rigidbody>();
    }
    void Update ()
    {
        //updates after every frame of movement
        
    }
    void FixedUpdate ()
    {
        //updates after every physics movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
        if (Input.GetKeyDown("space")&& rb.position.y<.60 && rb.position.y>.40)
        {
            rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
        }

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
    void SetCountText()
    {
        countText.text = "SCORE: " + pickupCount.ToString();
        if (pickupCount >= 4)
        {
            //winText.text = "You Win!";
        }
    }
}


    
