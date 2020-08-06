using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behaviour
{
    public virtual void Update(Player_Controller player, EnemyController enemy) { }

    public virtual void OnCollisionEnterPlayer(Player_Controller player, EnemyController enemy)
    {
        player.GetComponent<Player_Controller>().health -= enemy.EnemyType.destroy_damage;
        Object.Destroy(enemy.gameObject);
    }
}
