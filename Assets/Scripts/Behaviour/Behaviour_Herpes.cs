using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Behaviour_Herpes : Enemy_Behaviour
{
    public override void Update(PlayerController player, EnemyController enemy)
    {
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, player.transform.position, enemy.EnemyType.speed * Time.deltaTime);
    }
}