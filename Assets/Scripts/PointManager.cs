using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PointManager : MonoBehaviour {
    public List<string> things = new List<string>();
    public string pointName { get { return gameObject.name; } }
    public int Id { get; set; }
    public int row { get; set;  }
    public int column { get; set; }
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
