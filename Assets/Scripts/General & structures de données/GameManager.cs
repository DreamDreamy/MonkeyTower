using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public float gameSpeed;

    void Start()
    {
        gameSpeed = PlayerStats.Instance.gameSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        gameSpeed += 0.001f;
    }
}
