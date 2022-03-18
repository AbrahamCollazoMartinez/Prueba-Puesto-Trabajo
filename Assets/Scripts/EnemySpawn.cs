using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    [SerializeField]private PositionsManager PM;
    float PositionRandom;
    float Spwan_Delay_Seconds = 5f;

    GameObject[] EnemiesCount;

    private void Start()
    {
        PositionRandom = Random.Range(1, PM.Positions.Length);

        Instantiate(Enemy, PM.Positions[(int)PositionRandom].transform);
        InvokeRepeating("Spawn_Enemy", Spwan_Delay_Seconds, Spwan_Delay_Seconds);
    }


    private void Spawn_Enemy()
    {
   
        EnemiesCount = GameObject.FindGameObjectsWithTag("Enemy");

        if (EnemiesCount.Length < 5)
        {
            PositionRandom = Random.Range(1, PM.Positions.Length);

            Instantiate(Enemy, PM.Positions[(int)PositionRandom].transform);


        }
    }
}
