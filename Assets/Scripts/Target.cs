using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Enemy enemy;

    void Start()
    {
        enemy = GetComponent<Enemy>();

    }

    public void Hit()
    {
        enemy.isdead = true;
        Statistics.scoreInt += 1;
    }
}
