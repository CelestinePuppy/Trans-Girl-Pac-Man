using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    [SerializeField]
    int width, height;
    bool[,] mapArray;
    
    // Start is called before the first frame update
    void Start()
    {
        mapArray = new bool[width, height];

        BuildMapArrayFromTiles();
        PrintMapArray();    
    }
    void BuildMapArrayFromTiles()
    {
        Transform[] children = GetComponentsInChildren<Transform>();

        foreach (Transform child in children)
        {
            int x = Mathf.RoundToInt(child.position.x);
            int y = Mathf.RoundToInt(child.position.y);
            Debug.Log(child.position + " " + x + "," + y);
            child.position = new Vector2(x, y);
            mapArray[x, y] = true;
        }
    }

    void PrintMapArray()
    {
        for (int i = 0; i < mapArray.GetLength(0); i++)
        {
            string row = "";

            for (int j = 0; j < mapArray.GetLength(1); j++)
            {
                bool here = mapArray[i, j];
                if (here)
                {
                    row += "1";
                }
                else
                {
                    row = "0";
                }
            }
            Debug.Log(row);
        }
    }
}
