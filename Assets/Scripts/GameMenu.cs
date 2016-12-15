using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour {

    GameObject player;
    public bool ispaused;
    public bool guipaused;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && ispaused == false)
        {
            ispaused = true;
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && ispaused == true)
        {
            Cursor.visible = false;
            ispaused = false;
            Time.timeScale = 1;
        }
        if (ispaused == true)
        {
            player.GetComponent<PlayerController>().enabled = false;
            guipaused = true;

        }
        else if (ispaused == false)
        {
            player.GetComponent<PlayerController>().enabled = true;
            guipaused = false;

        }
    }
    public void OnGUI()
    {
        if (guipaused == true)
        {
            Cursor.visible = true;
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2) - 150f, 150f, 45f), "Продолжить"))
            {
                ispaused = false;
                Cursor.visible = false;
                Time.timeScale = 1;
            }
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2) - 100f, 150f, 45f), "В меню"))
            {
                ispaused = false;
                Application.LoadLevel("MainMenu");
            }
            
        }
    }
    
}
