using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : Singleton<PlayerStats>
{
    public float damage = 1f;
    public float bananaHeal = 0.25f;
    public int scoreSpeed = 1;
    public float gameSpeed = 2.5f;
}
