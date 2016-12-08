using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PointManager : MonoBehaviour {
    public List<string> things = new List<string>();
    public string pointName { get { return gameObject.name; } }
    public int Id { get; set; }
    public int row { get { return int.Parse(pointName[5].ToString()); }  }
    public int column { get { return int.Parse(pointName[6].ToString()); } }
    public string tag { get; set; }
    // Use this for initialization
    void Start () {
        if (things.Count != 0)
            foreach (var n in things)
            {
                GameObject thing = Instantiate(Resources.Load(n) as GameObject, transform.position, Quaternion.identity) as GameObject;
                if(thing.name.Contains("tile"))
                {
                    thing.GetComponent<SpriteRenderer>().sortingLayerName = "Terrain";
                }
            }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
