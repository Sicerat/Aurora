using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameMasterScript : MonoBehaviour {
    public static GameMasterScript Instance;
    public PlayerStatistics savedPlayerData = new PlayerStatistics();
    public List<int> plan = new List<int>();
    public int PlayerEnterBattlePoint_row;
    public int PlayerEnterBattlePoint_column;
    public Vector3 PlayerEnterBattlePoint_position;

    void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            int[] loaded = new int[] { 0, 0, 1, 0, 2, 0, 0, 2, 3 };
            Instance.plan.AddRange(loaded);
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
