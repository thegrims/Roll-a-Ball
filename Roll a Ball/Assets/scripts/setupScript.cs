﻿using UnityEngine;
using System.Collections;

public class setupScript : MonoBehaviour {
    public GameObject pickUp;
    public GameObject pickUp2;
    public int xmapsize, zmapsize;
    // Use this for initialization
    //do random cell generation and backtracking
    void Start ()
    {
        int finishpointX = 0;
        int finishpointy = 0;
        var numbers = new int[xmapsize, zmapsize];
        for (int z = 0; z < xmapsize; z++)
        {
            for (int x = 0; x < zmapsize; x++)
            {
                numbers[z,x]=1;
            }
        }
        for (int z = 0; z < xmapsize; z++)
        {
            for (int x = 0; x < zmapsize; x++)
            {
                if (Random.value > 0.9f)
                {
                    for (int y = z; y < z+3; y++)
                    {
                        for (int v = x; v < x+3; v++)
                        {
                            if (y<xmapsize && v<zmapsize)
                            {
                                numbers[y, v] = 0;
                            }
                        }
                    }
                }
            }
        }
        for (int z = 0; z < 50; z++)
        {
            for (int x = 0; x < 50; x++)
            {
                if (numbers[z,x]==1)
                {
                    Instantiate(pickUp, new Vector3(x, -5, z), Quaternion.identity);
                    if (z+x>finishpointX+finishpointy)
                    {
                        finishpointX = z;
                        finishpointy = x;
                    }
                }
                if (Random.value<0.5f)
                {
                 //   Instantiate(pickUp2, new Vector3(x, 0, z), Quaternion.identity);
                }
            }
        }
        Instantiate(pickUp2, new Vector3(finishpointy-.5f, 0.5f,finishpointX-.5f), Quaternion.identity);
}
	
	// Update is called once per frame
	void Update () {
	
	}
}
