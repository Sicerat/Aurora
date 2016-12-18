using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        var texts = GetComponentsInChildren<Text>();
        foreach (var n in texts)
        {
            switch (n.gameObject.name)
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
    void Update()
    {

    }

    public void OnGUI()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            Cursor.visible = true;
            Time.timeScale = 0;
            if (GUI.Button(new Rect((float)(Screen.width / 2) - 75f, (float)(Screen.height / 2) - 150f, 150f, 45f), string.Format("Вы победили! Счёт: {0}", GameMasterScript.Instance.savedPlayerData.XP)))
            {
                Destroy(GameObject.Find("GameMaster"));
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
