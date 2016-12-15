using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour {
    GameObject enemyHPText;
    GameObject playerHPText;
    EnemyInterface enemy;
    GameObject player;

    // Use this for initialization
    void Start () {
        Cursor.visible = true;
        enemyHPText = GameObject.Find("EnemyHP");
        playerHPText = GameObject.Find("PlayerHP");
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent(player.GetComponent<PlayerState>().localPlayerData.things[1]) as EnemyInterface;


    }
	
	// Update is called once per frame
	void Update () {
        enemyHPText.GetComponent<Text>().text = enemy.HP.ToString();
        playerHPText.GetComponent<Text>().text = GameObject.FindGameObjectWithTag("Player").GetComponent<BattlePlayerController>().localPlayerData.HP.ToString();
    }

    public void SceneChanged()
    {
        Application.LoadLevel("1");
    }
}
