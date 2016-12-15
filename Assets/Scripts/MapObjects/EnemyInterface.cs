using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface EnemyInterface  {

    string Name { get; }
    float HP { get; set; }
	float PhysRes { get; }
    float MagicRes { get; }
    void ReceiveDamage(int attackType, float damage);
}
