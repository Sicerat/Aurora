using UnityEngine;
using System.Collections;
using System.Linq;

public class MapManager : MonoBehaviour {

    void Awake()
    {
        var plan = new int[] { 0, 0, 1, 0, 2, 0, 0, 0, 3 };
        var points = GameObject.FindGameObjectsWithTag("Point").ToList().OrderBy(n => n.name).ToList();
        for (int i = 0; i < points.Count(); i++)
        {
            points[i].GetComponent<PointManager>().Id = plan[i];
            switch(plan[i])
            {
                case 0:
                    points[i].GetComponent<PointManager>().things.Add("Terrain/tile1");
                    break;
                case 1:
                    points[i].GetComponent<PointManager>().things.Add("Terrain/tile1");
                    points[i].GetComponent<PointManager>().things.Add("TimeKiller");
                    points[i].GetComponent<PointManager>().tag = "Enemy";
                    break;
                case 2:
                    points[i].GetComponent<PointManager>().things.Add("Terrain/tile2");
                    points[i].GetComponent<PointManager>().tag = "Obstacle";
                    break;
                case 3:
                    points[i].GetComponent<PointManager>().things.Add("Terrain/tile1");
                    points[i].GetComponent<PointManager>().things.Add("Merchant");
                    points[i].GetComponent<PointManager>().tag = "Shop";
                    break;
            }
        }
    }
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
