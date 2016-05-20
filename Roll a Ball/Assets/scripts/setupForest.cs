using UnityEngine;
using System.Collections;

public class setupForest : MonoBehaviour {

    public GameObject floorNode;
    public GameObject floorPathX;
    public GameObject floorPathY;
    public GameObject forestPathX;
    public GameObject forestPathY;
    public GameObject tree;
    public GameObject pickUp2;
    public int xmapsize, zmapsize;
    public float holesizeX, holesizeY;
    public float holeProb;
    // int holetype;
    // Use this for initialization
    //do random cell generation and backtracking
    void Start()
    {

        //holesizeX = Random.Range(4,7);
        //holesizeY = Random.Range(4, 7);
        //holeProb = (holesizeX-2)/100+(holesizeY-2)/100+.9f;
        Debug.Log(holesizeX); Debug.Log(holesizeY); Debug.Log(holeProb);
        //holetype = Random.Range(0, 2);
        var finishpointY = new int[4];
        var finishpointX = new int[4];
        var finishHeight = new int[4];
        for (int z = 0; z < 3; z++)
        {
            finishpointX[z] = 0;
            finishpointY[z] = 0;
        }
        finishpointX[3] = xmapsize;
        finishpointY[3] = zmapsize;

        var numbers = new int[xmapsize / 5, zmapsize / 5];

        for (int z = 0; z < xmapsize / 5; z++)
        {
            for (int x = 0; x < zmapsize / 5; x++)
            {
                //if (holetype==0)
                {
                    numbers[z, x] = 0;
                }
                //else
                //{
                //    numbers[z, x] = 1;
                //}
            }
        }
        for (int z = 0; z < xmapsize / 5; z++)
        {
            for (int x = 0; x < zmapsize / 5; x++)
            {
                //if (Random.value > holeProb)
                {
                    //for (int y = z; y < z+holesizeX; y++)
                    {
                        //for (int v = x; v < x+holesizeX; v++)
                        {
                            //if (y<xmapsize/5 && v<zmapsize/5)
                            {
                                int rand = Random.Range(1, 13);
                                if ((rand == 1) || (rand == 2) || (rand== 3) || (rand == 4))
                                {
                                    //numbers[x, z] = 1;
                                }
                                else if ((rand==5)||(rand==6) ||(rand==7) )
                                {
                                    numbers[x, z] = 2;
                                }
                                else if ((rand == 8) ||(rand==9) || (rand==10))
                                {
                                    numbers[x, z] = 3;
                                }
                                else if (rand == 11 )
                                {
                                    numbers[x, z] = 4;
                                }
                                else if (rand == 12)
                                {
                                    numbers[x, z] = 5;
                                }
                            }
                        }
                    }
                }
            }
        }
        for (int z = 0; z < xmapsize / 5; z++)
        {
            for (int x = 0; x < zmapsize / 5; x++)
            {
                if (numbers[z, x] == 1)
                {
                    //Debug.Log("blah");
                    int rand = Random.Range(0, 2);
                    Instantiate(floorNode, new Vector3(x * 5 - xmapsize / 2, -5+rand, z * 5 - zmapsize / 2), Quaternion.identity);
                /*    int rand = Random.Range(1, 4);
                    if (rand == 1)
                    {
                        Instantiate(tree, new Vector3((x * 5 - .5f) - xmapsize / 2, 0, (z * 5 - .5f) - zmapsize / 2), Quaternion.identity);
                    }*/
                    pickupPos(z, x, finishpointX, finishpointY,finishHeight,rand); 

                }
                else if (numbers[z, x] == 2)
                {
                    int rand = Random.Range(0, 2);
                    Instantiate(floorPathX, new Vector3(x * 5 - xmapsize / 2, -5 + rand, z * 5 - zmapsize / 2), Quaternion.identity);
                  /*  int rand = Random.Range(1, 4);
                    if (rand == 1)
                    {
                        Instantiate(tree, new Vector3((x * 5 - .5f) - xmapsize / 2, 0, (z * 5 - .5f) - zmapsize / 2), Quaternion.identity);
                    }*/
                    pickupPos(z, x, finishpointX, finishpointY,finishHeight,rand);

                }
                else if (numbers[z, x] == 3)
                {
                    int rand = Random.Range(0, 2);
                    Instantiate(floorPathY, new Vector3(x * 5 - xmapsize / 2, -5 + rand, z * 5 - zmapsize / 2), Quaternion.identity);
                   /* int rand = Random.Range(1, 4);
                    if (rand == 1)
                    {
                        Instantiate(tree, new Vector3((x * 5 - .5f) - xmapsize / 2, 0, (z * 5 - .5f) - zmapsize / 2), Quaternion.identity);
                    }*/
                    pickupPos(z, x, finishpointX, finishpointY,finishHeight,rand);

                }
                else if (numbers[z,x] == 4 )
                {
                    int rand = Random.Range(0, 2);
                    Instantiate(forestPathY, new Vector3(x * 5 - xmapsize / 2, -5 + rand, z * 5 - zmapsize / 2), Quaternion.identity);
                    /* int rand = Random.Range(1, 4);
                     if (rand == 1)
                     {
                         Instantiate(tree, new Vector3((x * 5 - .5f) - xmapsize / 2, 0, (z * 5 - .5f) - zmapsize / 2), Quaternion.identity);
                     }*/
                    //pickupPos(z, x, finishpointX, finishpointY);

                }
                else if (numbers[z, x] == 5)
                {
                    int rand = Random.Range(0, 2);
                    Instantiate(forestPathX, new Vector3(x * 5 - xmapsize / 2, -5 + rand, z * 5 - zmapsize / 2), Quaternion.identity);
                    /* int rand = Random.Range(1, 4);
                     if (rand == 1)
                     {
                         Instantiate(tree, new Vector3((x * 5 - .5f) - xmapsize / 2, 0, (z * 5 - .5f) - zmapsize / 2), Quaternion.identity);
                     }*/
                    //pickupPos(z, x, finishpointX, finishpointY);

                }
                //if (playerController.winTrigger == true)
                //{
                //    Debug.Log("win");
                //if (numbers[z, x] == 1)
                //{
                //    pickUp.transform.position = new Vector3(0,-20, 0);
                //}
                // }
            }
        }
        Instantiate(pickUp2, new Vector3(finishpointY[0] * 5 - xmapsize / 2 - .5f, 0.5f + finishHeight[0], finishpointX[0] * 5 - zmapsize / 2 - .5f), Quaternion.identity);
        Instantiate(pickUp2, new Vector3(finishpointY[1] * 5 - xmapsize / 2 - .5f, 0.5f + finishHeight[1], finishpointX[1] * 5 - zmapsize / 2 - .5f), Quaternion.identity);
        Instantiate(pickUp2, new Vector3(finishpointY[2] * 5 - xmapsize / 2 - .5f, 0.5f + finishHeight[2], finishpointX[2] * 5 - zmapsize / 2 - .5f), Quaternion.identity);
        Instantiate(pickUp2, new Vector3(finishpointY[3] * 5 - xmapsize / 2 - .5f, 0.5f + finishHeight[3], finishpointX[3] * 5 - zmapsize / 2 - .5f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void pickupPos(int z, int x, int[] finishpointX, int[] finishpointY, int[] finishHeight,int rand)
    {
        if ((z + x) > (finishpointX[0] + finishpointY[0]))
        {
            finishpointX[0] = z;
            finishpointY[0] = x;
            finishHeight[0] = rand; 
        }
        if ((z + x) < (finishpointX[3] + finishpointY[3]))
        {
            finishpointX[3] = z;
            finishpointY[3] = x;
            finishHeight[3] = rand;
        }
        if ((z - x) < (finishpointX[2] - finishpointY[2]))
        {
            finishpointX[2] = z;
            finishpointY[2] = x;
            finishHeight[2] = rand;
        }
        if ((z - x) > (finishpointX[1] - finishpointY[1]))
        {
            finishpointX[1] = z;
            finishpointY[1] = x;
            finishHeight[1] = rand;
        }
    }
}

