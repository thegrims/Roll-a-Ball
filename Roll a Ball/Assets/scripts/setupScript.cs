using UnityEngine;
using System.Collections;

public class setupScript : MonoBehaviour {
    public GameObject pickUp;
	// Use this for initialization
	void Start ()
    {
        for (int z = -8; z < 10; z+=2)
        {
            for (int x = -8; x < 10; x+=2)
            {   //if (rnd.Next(1, 13);)
                Instantiate(pickUp, new Vector3(x,0.5f, z), Quaternion.identity);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
