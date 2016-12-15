using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {

    public static PlayerState Instance;

    public Transform playerPosition;

    //TUTORIAL
    public PlayerStatistics localPlayerData = new PlayerStatistics();

    void Awake()
    {
        if (Instance == null)
            Instance = this;

        if (Instance != this)
            Destroy(gameObject);

        
    }

    //At start, load data from GlobalControl.
    void Start()
    {
        localPlayerData = GameMasterScript.Instance.savedPlayerData;
    }

    public void SavePlayer()
    {
        GameMasterScript.Instance.savedPlayerData = localPlayerData;
    }

    void Update()
    {

    }
     void OnDestroy()
    {
        SavePlayer();
    }
}
