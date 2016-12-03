using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour {
    GameObject enemyHPText;
    GameObject playerHPText;

    // Use this for initialization
    void Start () {
        enemyHPText = GameObject.Find("EnemyHP");
        playerHPText = GameObject.Find("PlayerHP");
    }
	
	// Update is called once per frame
	void Update () {
        enemyHPText.GetComponent<Text>().text = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>().HP.ToString();
        playerHPText.GetComponent<Text>().text = GameObject.FindGameObjectWithTag("Player").GetComponent<BattlePlayerController>().localPlayerData.HP.ToString();
    }
}
