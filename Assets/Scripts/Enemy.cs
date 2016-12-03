using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
    public int HP = 100;
    GameObject enemyHPText;
    // Use this for initialization
    void Start () {
        enemyHPText = GameObject.Find("EnemyHP");
	}
	
	// Update is called once per frame
	void Update () {
        enemyHPText.GetComponent<Text>().text = HP.ToString();
	}
    
    public void ReceiveDamage()
    {
        HP = HP - 10;
    }
}
