using UnityEngine;
using System.Collections;

public class setupScript : MonoBehaviour {
    public GameObject pickUp;
	// Use this for initialization
    //do random cell generation and backtracking
	void Start ()
    {
        for (int z = -50; z < 50; z++)
        {
            for (int x = -50; x < 50; x++)
            {
                if (Random.value>0.5f)
                {
                    Instantiate(pickUp, new Vector3(x, 0, z), Quaternion.identity);
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
