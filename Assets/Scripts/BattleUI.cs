using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleUI : MonoBehaviour {
    GameObject enemyHPText;
    GameObject playerHPText;
    EnemyInterface enemy;
    GameObject player;
    GameObject battleController;

    // Use this for initialization
    void Start () {
        Cursor.visible = true;
        enemyHPText = GameObject.Find("EnemyHP");
        playerHPText = GameObject.Find("PlayerHP");
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent(player.GetComponent<PlayerState>().localPlayerData.things[1]) as EnemyInterface;
        battleController = GameObject.Find("BattleController");


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

    public void OnGUI()
    {
        if(battleController.GetComponent<BattleController>().OnLose)
        {
            if (GUI.Button(new Rect((float)(Screen.width / 2) - 75f, (float)(Screen.height / 2) - 150f, 150f, 45f),"Вы проиграли!"))
            {
                Destroy(GameObject.Find("GameMaster"));
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
