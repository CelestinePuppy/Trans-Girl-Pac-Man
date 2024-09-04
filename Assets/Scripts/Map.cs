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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
