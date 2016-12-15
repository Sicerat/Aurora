using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForAttackButton : MonoBehaviour {

    BattleController controller;
    Button button;
    // Use this for initialization
    void Start()
    {
        button = GetComponent<Button>();
        controller = GameObject.Find("BattleController").GetComponent<BattleController>();
        button.onClick.AddListener(controller.Attack);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
