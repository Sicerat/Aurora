using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        var points = TransformIntoMatrix(GameObject.FindGameObjectsWithTag("Point").ToList().OrderBy(n => n.name).ToList());
        transform.position = GetComponent<PlayerState>().localPlayerData.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckPoint(-1, 0);
            GetComponent<PlayerState>().localPlayerData.currentRow--;
            transform.Translate(0, 1, 0);
            GetComponent<PlayerState>().localPlayerData.position = transform.position;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CheckPoint(1, 0);
            GetComponent<PlayerState>().localPlayerData.currentRow++;
            transform.Translate(0, -1, 0);
            GetComponent<PlayerState>().localPlayerData.position = transform.position;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CheckPoint(0, -1);
            GetComponent<PlayerState>().localPlayerData.currentColumn--;
            transform.Translate(-1, 0, 0);
            GetComponent<PlayerState>().localPlayerData.position = transform.position;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CheckPoint(0, 1);
            GetComponent<PlayerState>().localPlayerData.currentColumn++;
            transform.Translate(1, 0, 0);
            GetComponent<PlayerState>().localPlayerData.position = transform.position;

        }

    }

    public void CheckPoint(int deltaRow, int deltaColumn)
    {
        var nextPoint = GameObject.Find("Point" + (GetComponent<PlayerState>().localPlayerData.currentRow + deltaRow) + (GetComponent<PlayerState>().localPlayerData.currentColumn + deltaColumn));
        //Debug.Log(nextPoint.name + ", " + nextPoint.GetComponent<PointManager>().enemy);
        if (nextPoint.GetComponent<PointManager>().thing == "Waterling")
        {
            
            Application.LoadLevel("Battle");
        }
        if(nextPoint.GetComponent<PointManager>().thing == "Merchant")
        {

        }
    }

    void OnDestroy()
    {
        
    }

    GameObject[,] TransformIntoMatrix(List<GameObject> list)
    {
        var size = (int)Math.Sqrt(list.Count);
        var matrix = new GameObject[size,size];
        for(int i=0; i < size; i++)
        {
            for(int j=0; j < size; j++)
            {
                matrix[i, j] = list[i*size + j];
            }
        }
        return matrix;
    }
}


