﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    public Player_Controller Player;

    public int max_health = 20;
    public int start_health = 15;
    public int health;

    private void Awake()
    {
        health = start_health;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
