using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {
    
    
	// Use this for initialization
	void Start () {
        var texts = GetComponentsInChildren<Text>();
        foreach(var n in texts)
        {
            switch(n.gameObject.name)
            {
                case "HP":
                    n.text = GameMasterScript.Instance.savedPlayerData.HP.ToString();
                    break;
                case "XP":
                    n.text = GameMasterScript.Instance.savedPlayerData.XP.ToString();
                    break;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
