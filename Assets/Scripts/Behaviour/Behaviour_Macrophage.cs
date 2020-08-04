using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour_Macrophage : Enemy_Behaviour
{
    public Vector3 max_x = Vector3.zero;
    public Vector3 min_x = Vector3.zero;
    public int direction = 1; // 1 = max 0 = min

    public Behaviour_Macrophage (Vector3 position)
    {
        max_x = position + new Vector3(+2.0f, 0.0f, 0.0f);
        min_x = position + new Vector3(-2.0f, 0.0f, 0.0f);
    }

    public override void Update(PlayerController player, EnemyController enemy)
    {
        if ((direction == 1) && (enemy.transform.position.x >= max_x.x))
            direction = 0;
        if ((direction == 0) && (enemy.transform.position.x <= min_x.x))
            direction = 1;

        if (direction == 1)
            enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, max_x, enemy.EnemyType.speed * Time.deltaTime);
        if (direction == 0)
            enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, min_x, enemy.EnemyType.speed * Time.deltaTime);



        enemy.Fire(Vector3.up, 1);
        enemy.Fire(Vector3.down, 1);
        enemy.Fire(Vector3.left, 1);
        enemy.Fire(Vector3.right, 1);
        enemy.Fire(Vector3.up + Vector3.right, 1);
        enemy.Fire(Vector3.down + Vector3.right, 1);
        enemy.Fire(Vector3.up + Vector3.left, 1);
        enemy.Fire(Vector3.down + Vector3.left, 1);
    }
}
