using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
    public float speed;
    private int pickupCount = 0;
    private Rigidbody rb;
    void Start()
    {
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
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pick up"))
        {
            pickupCount++;
            if (pickupCount==3)
            {
                Application.LoadLevel("minigame2");
            }
            other.gameObject.SetActive(false);
        }
    }
}


    
