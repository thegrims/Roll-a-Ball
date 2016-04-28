using UnityEngine;
using System.Collections;

public class setupScript : MonoBehaviour {
    public GameObject pickUp;
    public GameObject pickUp2;
    public int xmapsize, zmapsize;
    public float holesizeX, holesizeY;
    
    float holeProb;
    // Use this for initialization
    //do random cell generation and backtracking
    void Start ()
    {
        holesizeX = Random.Range(2,6);
        holesizeY = Random.Range(2, 6);
        holeProb = holesizeX/150+holesizeY/150+.9f;
        Debug.Log(holesizeX); Debug.Log(holesizeY); Debug.Log(holeProb);

        var finishpointY = new int[4];
        var finishpointX = new int[4];
        for (int z = 0; z < 4; z++)
        {
            finishpointX[z] = 0;
            finishpointY[z] = 0;
        }

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
                    for (int y = z; y < z+holesizeX; y++)
                    {
                        for (int v = x; v < x+holesizeY; v++)
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
        for (int z = 0; z < xmapsize; z++)
        {
            for (int x = 0; x < zmapsize; x++)
            {
                if (numbers[z,x]==1)
                {
                    Instantiate(pickUp, new Vector3(x-xmapsize/2, -5, z-zmapsize/2), Quaternion.identity);
                    if (z+x>finishpointX[0]+finishpointY[0])
                    {
                        finishpointX[0] = z;
                        finishpointY[0] = x;
                    }
                    if (z + x < finishpointX[1] + finishpointY[1])
                    {
                        finishpointX[1] = z;
                        finishpointY[1] = x;
                    }
                    if (z - x < finishpointX[2] - finishpointY[2])
                    {
                        finishpointX[2] = z;
                        finishpointY[2] = x;
                    }
                    if (z - x > finishpointX[3] - finishpointY[3])
                    {
                        finishpointX[3] = z;
                        finishpointY[3] = x;
                    }

                }
                if (playerController.winTrigger == true)
                {
                    Debug.Log("win");
                    if (numbers[z, x] == 1)
                    {
                        pickUp.transform.position = new Vector3(0,-20, 0);
                    }
                }
                //if (Random.value<0.5f)
                //{
                 //   Instantiate(pickUp2, new Vector3(x, 0, z), Quaternion.identity);
                //}
            }
        }
        Instantiate(pickUp2, new Vector3(finishpointY[0]-25.5f, 0.5f,finishpointX[0]-25.5f), Quaternion.identity);
        Instantiate(pickUp2, new Vector3(finishpointY[1] - 25.5f, 0.5f, finishpointX[1] - 25.5f), Quaternion.identity);
        Instantiate(pickUp2, new Vector3(finishpointY[2] - 25.5f, 0.5f, finishpointX[2] - 25.5f), Quaternion.identity);
        Instantiate(pickUp2, new Vector3(finishpointY[3] - 25.5f, 0.5f, finishpointX[3] - 25.5f), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
