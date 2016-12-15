using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class BattleController : MonoBehaviour
{
    
    float time;
    BattlePlayerController player;
    int playerAttackType;
    float damage;
    Button attack;
    Text timeText;
    EnemyInterface enemy;
    // Use this for initialization
    void Start()
    {
        
        time = Random.value * 10 + 1f;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<BattlePlayerController>();
        playerAttackType = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerState>().localPlayerData.attackType;
        damage = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerState>().localPlayerData.damage;
        GameObject e = Instantiate(Instantiate(Resources.Load(player.GetComponent<PlayerState>().localPlayerData.things[1]) as GameObject,  new Vector3(7,0,0), Quaternion.identity)) as GameObject;
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent(typeof(EnemyInterface)) as EnemyInterface;
        timeText = GameObject.Find("Time").GetComponent<Text>();
        timeText.text = time.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.HP <= 0)
        {
            Win();
        }
        if(player.localPlayerData.HP <= 0)
        {
            GameOver();
        }
        timeText.text = time.ToString();
        time = time - Time.deltaTime;
        if (time <= 0)
        {
            player.GetComponent<BattlePlayerController>().ReceiveDamage();
            time = Random.value * 10 + 1f;
            timeText.text = time.ToString();
        }
        

    }

    public void Attack()
    {

        if (time < 0.1)
        {
           enemy.ReceiveDamage(playerAttackType, damage);
        }
        else if (time < 0.5 && time >= 0.1)
            enemy.ReceiveDamage(playerAttackType, damage*0.8f);
        else if (time < 1 && time >= 0.5)
            enemy.ReceiveDamage(playerAttackType, damage*0.5f);
        else if (time >= 1)
            player.ReceiveDamage();
        time = Random.value * 10 + 1f;
        timeText.text = time.ToString();

    }

    void GameOver()
    {
        Application.LoadLevel("MainMenu");
    }

    void Win()
    {
        player.GetComponent<BattlePlayerController>().localPlayerData.XP++;
        Application.LoadLevel("1");
    }
}

