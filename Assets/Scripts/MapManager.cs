using UnityEngine;
using System.Collections;
using System.Linq;

public class MapManager : MonoBehaviour {

    void Awake()
    {
        var plan = new int[] { 0, 9, 1, 0, 0, 0, 0, 0, 3 };
        var points = GameObject.FindGameObjectsWithTag("Point").ToList().OrderBy(n => n.name).ToList();
        for (int i = 0; i < points.Count(); i++)
        {
            points[i].GetComponent<PointManager>().Id = plan[i];
            switch(plan[i])
            {
                case 0:
                    break;
                case 1:
                    points[i].GetComponent<PointManager>().thing = "Waterling";
                    break;
                case 3:
                    points[i].GetComponent<PointManager>().thing = "Merchant";
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
