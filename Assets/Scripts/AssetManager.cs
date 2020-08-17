using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetManager : MonoBehaviour
{
    private static AssetManager _instance;

    public static AssetManager Instance { get { return _instance; } }
    public Player_Controller Player;
    public Player_Controller Player_Prefab;
    public Camera_Controller Camera;
    public Enemy_Controller Bomber;
    public Enemy_Controller Aids;
    public Enemy_Controller Herpes;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
}
