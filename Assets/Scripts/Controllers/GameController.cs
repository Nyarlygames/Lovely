using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameObject PlayerPrefab;
    private GameObject EnemyPrefab;
    GameObject Enemy;
    GameObject Player;
    Camera cam;


    void Awake()
    {
        PlayerPrefab = Resources.Load<GameObject>("prefabs/Player");
        EnemyPrefab = Resources.Load<GameObject>("prefabs/Enemy");
        Player = Instantiate(PlayerPrefab, PlayerPrefab.transform.position, Quaternion.identity) as GameObject;
        cam = Camera.main;
        cam.GetComponent<CameraController>().PlayerObject = Player;

        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        Enemy = Instantiate(EnemyPrefab, PlayerPrefab.transform.position + new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity) as GameObject;
        Enemy.GetComponent<EnemyController>().EnemyType = new Enemy_Bomber();

        Enemy = Instantiate(EnemyPrefab, PlayerPrefab.transform.position + new Vector3(2.0f, 2.0f, 0.0f), Quaternion.identity) as GameObject;
        Enemy.GetComponent<EnemyController>().EnemyType = new Enemy_Herpes();

        Enemy = Instantiate(EnemyPrefab, PlayerPrefab.transform.position + new Vector3(-2.0f, 2.0f, 0.0f), Quaternion.identity) as GameObject;
        Enemy.GetComponent<EnemyController>().EnemyType = new Enemy_Macrophage(Enemy.transform.position);

    }
    void Start()
    {
    }
    
    void Update()
    {
        
    }
}
