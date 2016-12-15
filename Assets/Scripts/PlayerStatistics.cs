using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[Serializable]
public class PlayerStatistics : MonoBehaviour {
    
    public float HP;
    public float XP;
    public int currentRow;
    public int currentColumn;
    public Vector3 position;
    public List<string> things = new List<string>();
    public int attackType;
    public float damage;
    // Use this for initialization
    void Awake()
    {
       
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
