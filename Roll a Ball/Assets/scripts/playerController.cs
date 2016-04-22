using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
    public float speed;
    public float jumpSpeed;
    private int pickupCount = 0;
    private Rigidbody rb;
    bool jumping = false;
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
    void Update ()
    {
        //updates after every frame of movement
        if (Input.GetKeyDown("space"))
        {
           // transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }
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
            if (pickupCount==10)
            {
                Application.LoadLevel("minigame2");
            }
            other.gameObject.SetActive(false);
        }
    }
}


    
