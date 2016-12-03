using UnityEngine;
using System.Collections;

public class PointManager : MonoBehaviour {
    public string enemy;
	// Use this for initialization
	void Start () {
        if (enemy != null && enemy != "")
        Instantiate(Resources.Load(enemy) as GameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
