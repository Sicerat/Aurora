using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBEditorScript : MonoBehaviour {
    DBEditor db = new DBEditor();
    public List<string> dataFromDB = new List<string>();
    void Awake()
    {
        DontDestroyOnLoad(gameObject); 
    }

	// Use this for initialization
	void Start () {
        dataFromDB = db.Getter();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
