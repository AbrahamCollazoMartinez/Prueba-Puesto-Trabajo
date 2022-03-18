using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public int EnemySpeed = 2;
    GameObject m_player;
    float Random_Number;

    PositionsManager PM;

    private void Awake()
    {
        m_player = GameObject.Find("Player");
    }

    private void Start()
    {
        PM = GameObject.FindGameObjectWithTag("Positions").GetComponent<PositionsManager>();
        Random_Number = Random.Range(0, PM.Positions.Length);
        InvokeRepeating("ChageLocation", 5f, 5f);
    }

    void Update () {
        //Vector3 localPosition = m_player.transform.position - transform.position;
        //localPosition = localPosition.normalized;
        //transform.Translate(localPosition.x * Time.deltaTime * EnemySpeed, 0f, localPosition.z * Time.deltaTime * EnemySpeed);

        


        Vector3 localPosition = PM.Positions[(int)Random_Number].position - transform.position;
        localPosition = localPosition.normalized;
        transform.Translate(localPosition.x * Time.deltaTime * EnemySpeed, 0f, localPosition.z * Time.deltaTime * EnemySpeed);


    }

    public void ChageLocation()
    {

 
        Random_Number = Random.Range(0, PM.Positions.Length);
    }
}
