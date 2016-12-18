using UnityEngine;
using System.Collections;
using System.Linq;
using System;
using System.Collections.Generic;

public class MapManager : MonoBehaviour {

    void Awake()
    {
        
    }
    // Use this for initialization
    void Start() {
        GeneratePoints(GameMasterScript.Instance.plan);
        WeNeedToBuildAWall(GameMasterScript.Instance.mapSize);
    }

    // Update is called once per frame
    void Update() {

    }

    void GeneratePoints(List<int> plan)
    {
        int n = GameMasterScript.Instance.mapSize;
        float x = -1.5f;
        float y = 0.5f;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                GameObject point = Instantiate(Resources.Load("Point") as GameObject, new Vector3(x,y,0), Quaternion.identity) as GameObject;
                point.GetComponent<PointManager>().row = i;
                point.GetComponent<PointManager>().column = j;
                point.name = string.Format("Point{0}{1}", i+1, j+1);
                switch (plan[i*n + j])
                {
                    case 0:
                        point.GetComponent<PointManager>().things.Add("Terrain/tile1");
                        break;
                    case 1:
                        point.GetComponent<PointManager>().things.Add("Terrain/tile1");
                        point.GetComponent<PointManager>().things.Add("TimeKiller");
                        point.GetComponent<PointManager>().tag = "Enemy";
                        break;
                    case 2:
                        point.GetComponent<PointManager>().things.Add("Terrain/tile2");
                        point.GetComponent<PointManager>().tag = "Obstacle";
                        break;
                    case 3:
                        point.GetComponent<PointManager>().things.Add("Terrain/tile1");
                        point.GetComponent<PointManager>().things.Add("TimeCaster");
                        point.GetComponent<PointManager>().tag = "Enemy";
                        break;
                    case 4:
                        point.GetComponent<PointManager>().things.Add("Terrain/tile1");
                        break;
                    case 5:
                        point.GetComponent<PointManager>().things.Add("Terrain/tile1");
                        break;
                    case 6:
                        point.GetComponent<PointManager>().things.Add("Terrain/tile1");
                        break;
                    case 7:
                        point.GetComponent<PointManager>().things.Add("Terrain/tile1");
                        break;
                    case 8:
                        point.GetComponent<PointManager>().things.Add("Terrain/tile1");
                        break;
                    case 9:
                        point.GetComponent<PointManager>().things.Add("Terrain/tile1");
                        break;
                }
                x = x + 1;
            }
            x = -1.5f;
            y = y - 1;
        }

    }

    void WeNeedToBuildAWall(int size)
    {
        float left_x = -2.5f;
        float left_y = 1.5f;
        float right_x = left_x + size + 1;
        float right_y = 1.5f;
        float up_x = -1.5f;
        float up_y = 1.5f;
        float down_x = -1.5f;
        float down_y = up_y - size - 1;
        for(int i = 0; i < size+2; i++)
        {
            Instantiate(Resources.Load("Terrain/Wall"), new Vector3(left_x, left_y, 0), Quaternion.identity);
            left_y = left_y - 1;
        }
        for(int i = 0; i < size+2; i++)
        {
            Instantiate(Resources.Load("Terrain/Wall"), new Vector3(right_x, right_y, 0), Quaternion.identity);
            right_y = right_y - 1;
        }
        for(int i = 0; i<size;i++)
        {
            Instantiate(Resources.Load("Terrain/Wall"), new Vector3(up_x, up_y, 0), Quaternion.identity);
            up_x = up_x+1;
        }
        for (int i = 0; i < size; i++)
        {
            Instantiate(Resources.Load("Terrain/tile1"), new Vector3(down_x, down_y, 0), Quaternion.identity);
            GameObject wall = Instantiate(Resources.Load("Terrain/Wall") as GameObject, new Vector3(down_x, down_y, 0), Quaternion.identity) as GameObject;
            Color col;
            col = wall.GetComponent<SpriteRenderer>().color;
            col.a = 0.5f;
            wall.GetComponent<SpriteRenderer>().color = col;
            down_x = down_x + 1;
        }

    }
}
