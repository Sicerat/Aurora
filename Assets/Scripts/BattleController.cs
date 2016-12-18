using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleController : MonoBehaviour
{
    
    float time;
    float atime;
    BattlePlayerController player;
    Button AttackButton;
    int playerAttackType;
    float damage;
    Button attack;
    Text timeText;
    EnemyInterface enemy;
    public bool OnLose;
    // Use this for initialization
    void Start()
    {
        AttackButton = GameObject.Find("Attack").GetComponent<Button>();
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
        atime = time - Mathf.Floor(time);
        if (atime <= 0.2)
        {
            var colors = AttackButton.colors;
            colors.normalColor = Color.red;
            colors.pressedColor = Color.red;
            colors.highlightedColor = Color.red;
            AttackButton.colors = colors;
        }
        if (atime > 0.2)
        {
            var colors = AttackButton.colors;
            colors.normalColor = Color.white;
            colors.pressedColor = Color.white;
            colors.highlightedColor = Color.white;
            AttackButton.colors = colors;
        }

        if (enemy.HP <= 0)
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
            GameOver();
            //player.GetComponent<BattlePlayerController>().ReceiveDamage();
            //time = Random.value * 10 + 1f;
            //timeText.text = time.ToString();
        }


    }

    public void Attack()
    {
        if (atime < 0.2)
        {
            enemy.ReceiveDamage(playerAttackType, damage);
        }
        else if (atime < 0.5 && atime >= 0.2)
        {
            enemy.ReceiveDamage(playerAttackType, damage * 0.5f);
            player.ReceiveDamage();
        }
        else if (atime < 1 && atime >= 0.5)
        {
            player.ReceiveDamage();
        }

    }

    void GameOver()
    {
        OnLose = true;
        Time.timeScale = 0;
    }

    void Win()
    {
        player.OnWin = true;
        SceneManager.LoadScene("1");
    }
}

