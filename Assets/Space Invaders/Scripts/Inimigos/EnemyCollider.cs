using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : Collider
{
    public override void GetHit()
    {
        Debug.Log("enemyHit");
    }
}