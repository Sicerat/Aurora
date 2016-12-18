using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;

public class GameMasterScript : MonoBehaviour {
    public static GameMasterScript Instance;
    public PlayerStatistics savedPlayerData = new PlayerStatistics();
    public List<string> levelsFromDB;
    public int mapSize;
    public int selectedLvl;
    public List<int> plan = new List<int>();
    public int PlayerEnterBattlePoint_row;
    public int PlayerEnterBattlePoint_column;
    public Vector3 PlayerEnterBattlePoint_position;

    void Awake()
    {
        if(Instance == null)
        {
            DBEditor db = new DBEditor();
            levelsFromDB = db.Getter();
            DontDestroyOnLoad(gameObject);
            Instance = this;
            mapSize = 3;
            selectedLvl = 0;
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

    public List<int> GetData(int size)
    {
        List<int> data = new List<int>();
        string s = New_Generator.StringMatrixGenerator(size);
        for(int i = 0; i < s.Length; i++)
        {
            data.Add((int.Parse(s[i].ToString())));
        }
        return data;

    }

    public List<int> LoadData(int index)
    {
        List<int> data = new List<int>();
        string s = levelsFromDB[index];
        mapSize = (int)System.Math.Sqrt(double.Parse(s.Length.ToString()));
        for(int i = 0; i< s.Length; i++)
        {
            data.Add((int.Parse(s[i].ToString())));
        }
        return data;
    }

}
