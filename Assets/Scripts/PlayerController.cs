using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour
{
    int currentRow, currentColumn;
    // Use this for initialization
    void Start()
    {
        currentColumn = GetComponent<PlayerState>().localPlayerData.currentColumn;
        currentRow = GetComponent<PlayerState>().localPlayerData.currentRow;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckPoint(-1, 0);
            currentRow--;

            transform.Translate(0, 1, 0);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CheckPoint(1, 0);
            currentRow++;

            transform.Translate(0, -1, 0);


        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CheckPoint(0, -1);
            currentColumn--;

            transform.Translate(-1, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CheckPoint(0, 1);
            currentColumn++;

            transform.Translate(1, 0, 0);

        }

    }

    public void CheckPoint(int deltaRow, int deltaColumn)
    {
        var nextPoint = GameObject.Find("Point" + (currentRow + deltaRow) + (currentColumn + deltaColumn));
        //Debug.Log(nextPoint.name + ", " + nextPoint.GetComponent<PointManager>().enemy);
        if (nextPoint.GetComponent<PointManager>().enemy != "")
        {
            Application.LoadLevel("Battle");
        }
    }
}


