using UnityEngine;
using System.Collections;

public class GameMasterScript : MonoBehaviour {
    public static GameMasterScript Instance;
    public PlayerStatistics savedPlayerData = new PlayerStatistics();
    void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            Debug.Log("YO");
        }
        else if(Instance!=this)
        {
            Destroy(gameObject);
        }
    }

    
	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
