using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behaviour
{
    public virtual void Update(PlayerController player, EnemyController enemy) { }

    public virtual void OnCollisionEnterPlayer(PlayerController player, EnemyController enemy) { }
}
