using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

    GameObject GenerateButton;
	// Use this for initialization
	void Start () {
        GenerateButton = GameObject.Find("GenerateButton");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GenerateLevel()
    {
        GameMasterScript.Instance.plan = GameMasterScript.Instance.GetData(GameMasterScript.Instance.mapSize);
        Application.LoadLevel("1");
    }


    public void OnGUI()
    {
        GUI.Box(new Rect((float)(Screen.width / 2) - 600f, (float)(Screen.height / 2) - 400f, 1200f, 220f), "Передвигайтесь по карте с помощью стрелочек. \n Если Вы попытаетесь войти на клетку с другим существом, начнется бой. \n Бой проходит по следующему алгоритму: \n 1) Игра генерирует и отображает время, отведенное на бой. \n 2) Вы можете наносить сколько угодно ударов, нажимая по кнопке Attack. \n 3) Вы наносите 100% урона, если атакуете не ранее, чем за 0.2 секунды до конца текущей секунды. \n 4) Вы наносите 50% урона и Вам наносят 10 ед. урона, если Вы атакуете в промежуток от 0.2 до 0.5 сек. до конца текущей секунды. \n 5) В случае, если Вы атакуете ранее, чем за 0.5 сек. до конца текущей секунды, Вы не наносите урон, но получаете его. \n 7) Вы побеждаете в бою, если опустите здоровье противника до 0. \n 8) Вы проигрываете, если ваше здоровье опустится до 0 или закончится время для боя. \n 9) Вы можете сбежать из боя, нажав на кнопку Run! \n Когда Вы побеждаете в бою, вы вновь попадаете на карту. Ваш счет увеличивается на 1. \n Уничтожьте всех врагов, чтобы одержать победу.");
    }

    
}
