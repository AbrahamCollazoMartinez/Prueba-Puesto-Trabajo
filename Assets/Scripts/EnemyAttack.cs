using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    Points PS;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
        else if(other.CompareTag("Bullet"))
        {
            PS = GameObject.FindGameObjectWithTag("Points").GetComponent<Points>();
            PS.EarnPoints(10);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }

}
