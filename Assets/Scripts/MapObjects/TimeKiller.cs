using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKiller : MonoBehaviour, EnemyInterface {

    public string Name { get { return "TimeKiller"; }}
    float hp = 100;
    public float HP { get { return hp; } set { hp = value; } }
    public float PhysRes { get { return 0.4f; } }  
    public float MagicRes { get { return 1.2f; }}  
    public void ReceiveDamage(int attackType, float damage)
    {

        if (attackType == 0)
            HP = HP - damage * PhysRes;
        if (attackType == 1)
            HP = HP - damage * MagicRes;
        Debug.Log(HP);
    }
}
