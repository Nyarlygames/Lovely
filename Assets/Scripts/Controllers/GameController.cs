using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player_Controller Player;
    public Camera_Controller cam;


    void Awake()
    {
        Player = Instantiate(AssetManager.Instance.Player);
        cam = Instantiate(AssetManager.Instance.Camera);
        cam.Player = Player;
    }

    void Start()
    {
    }
    
    void Update()
    {
        
    }
}
