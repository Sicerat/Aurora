using UnityEngine;
using System.Collections;
using System.Linq;
using System;
using System.Collections.Generic;

public class MapManager : MonoBehaviour {

    void Awake()
    {
        GeneratePoints(GameMasterScript.Instance.plan);
        
    }
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void GeneratePoints(List<int> plan)
    {
        int n = (int)Math.Sqrt(plan.Count());
        float x = -1.5f;
        float y = 0.5f;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j<n;j++)
            {
                GameObject point = Instantiate(Resources.Load("Point") as GameObject, new Vector3(x,y,0), Quaternion.identity) as GameObject;
                point.GetComponent<PointManager>().row = i;
                point.GetComponent<PointManager>().column = j;
                point.name = string.Format("Point{0}{1}", i+1, j+1);
                switch (plan[i*3 + j])
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
                }
                x = x + 1;
            }
            x = -1.5f;
            y = y - 1;
        }

    }
}
