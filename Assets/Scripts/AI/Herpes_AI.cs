using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herpes_AI : MonoBehaviour
{
    public Enemy_Controller Enemy;

    private Vector2 Move_X;
    private Vector2 Move_Y;
    private Vector3 Target;
    private bool Target_Acquired = false;

    void Start()
    {
        Move_X = new Vector2(Random.Range(-3, 0), Random.Range(0, 3));
        Move_Y = new Vector2(Random.Range(-3, 0), Random.Range(0, 3));
    }
    
    void Update()
    {
        if (Target_Acquired == false)
        {
            Target = Enemy.Spawner.transform.position + new Vector3(Random.Range(Move_X.x, Move_X.y), Random.Range(Move_Y.x, Move_Y.y), AssetManager.Instance.Herpes.transform.position.z);
            Target_Acquired = true;
        }
        else if (Vector2.Distance(transform.position, Target) < 0.01f)
            Target_Acquired = false;
        transform.position = Vector3.MoveTowards(transform.position, Target, Enemy.speed * Time.deltaTime);
    }
}
