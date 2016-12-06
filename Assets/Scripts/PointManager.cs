using UnityEngine;
using System.Collections;

public class PointManager : MonoBehaviour {
    public string thing;
    public string pointName { get { return gameObject.name; } }
    public int Id { get; set; }
    public int row { get { return int.Parse(pointName[5].ToString()); }  }
    public int column { get { return int.Parse(pointName[6].ToString()); } }

    // Use this for initialization
    void Start () {
        if (thing != null && thing != "")
        Instantiate(Resources.Load(thing) as GameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
