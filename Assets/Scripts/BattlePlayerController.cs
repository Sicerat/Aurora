using UnityEngine;
using System.Collections;

public class BattlePlayerController : MonoBehaviour {
    public bool OnWin = false;
    public PlayerStatistics localPlayerData = new PlayerStatistics();
	// Use this for initialization
	void Start () {
        localPlayerData = GameMasterScript.Instance.savedPlayerData;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(localPlayerData.HP);
	}

    public void ReceiveDamage()
    {
        localPlayerData.HP = localPlayerData.HP - 10;
    }

    public void SavePlayer()
    {
        if (OnWin)
        {
            Debug.Log("gfgfg");
            localPlayerData.XP++;
            GameMasterScript.Instance.plan[GameMasterScript.Instance.PlayerEnterBattlePoint_row * GameMasterScript.Instance.mapSize + GameMasterScript.Instance.PlayerEnterBattlePoint_column] = 0;
            localPlayerData.position = GameMasterScript.Instance.PlayerEnterBattlePoint_position;
            localPlayerData.currentRow = GameMasterScript.Instance.PlayerEnterBattlePoint_row+1;
            localPlayerData.currentColumn = GameMasterScript.Instance.PlayerEnterBattlePoint_column+1;
        }
        GameMasterScript.Instance.savedPlayerData = localPlayerData;
    }

    void OnDestroy()
    {
        SavePlayer();
    }
}
