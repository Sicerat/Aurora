using UnityEngine;
using System.Collections;

public class BattlePlayerController : MonoBehaviour {
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
        GameMasterScript.Instance.savedPlayerData = localPlayerData;
    }

    public void OnDestroy()
    {
        SavePlayer();
    }
}
