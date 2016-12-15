using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

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
            if (CheckPoint(-1, 0))
            {
                GetComponent<PlayerState>().localPlayerData.currentRow--;
                transform.Translate(0, 1, 0);
            }
            GetComponent<PlayerState>().localPlayerData.position = transform.position;
            

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (CheckPoint(1, 0))
            {
                GetComponent<PlayerState>().localPlayerData.currentRow++;
                transform.Translate(0, -1, 0);
            }
            GetComponent<PlayerState>().localPlayerData.position = transform.position;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (CheckPoint(0, -1))
            {
                GetComponent<PlayerState>().localPlayerData.currentColumn--;
                transform.Translate(-1, 0, 0);
            }
            GetComponent<PlayerState>().localPlayerData.position = transform.position;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (CheckPoint(0, 1))
            {
                GetComponent<PlayerState>().localPlayerData.currentColumn++;
                transform.Translate(1, 0, 0);
            }
            GetComponent<PlayerState>().localPlayerData.position = transform.position;

        }

    }

    public bool CheckPoint(int deltaRow, int deltaColumn)
    {
        var nextPoint = GameObject.Find("Point" + (GetComponent<PlayerState>().localPlayerData.currentRow + deltaRow) + (GetComponent<PlayerState>().localPlayerData.currentColumn + deltaColumn));
        //Debug.Log(nextPoint.name + ", " + nextPoint.GetComponent<PointManager>().enemy);
        if (nextPoint.GetComponent<PointManager>().tag == "Enemy")
        {
            GetComponent<PlayerState>().localPlayerData.things = nextPoint.GetComponent<PointManager>().things;
            SceneManager.LoadScene("Battle");
            return false;
        }
        if(nextPoint.GetComponent<PointManager>().tag == "Obstacle")
        {
            return false;
        }
        if (nextPoint.GetComponent<PointManager>().tag == "Shop")
        {
            return false;
        }
        return true;
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


