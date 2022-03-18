using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject BulletPrefab;
    public Transform BulletSpawn;
    public Transform Enemy;
    GameObject Player;
    public EnemyMovement EM;

    float DelayShoot = 5f;
    WaitForSeconds Stand_W = new WaitForSeconds(4f);
    WaitForSeconds Stand_S = new WaitForSeconds(1f);

    private void Start()
    {

        StartCoroutine(Stand());
    }

    IEnumerator Stand()
    {
        yield return Stand_W;
        EM.EnemySpeed = 0;
        StartCoroutine(Shot());

        
    }

    IEnumerator Shot()
    {
        yield return Stand_S;

        Player = GameObject.FindGameObjectWithTag("Player");
        Enemy.LookAt(Player.transform);
        var bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
        Destroy(bullet, 2.0f);
        EM.EnemySpeed = 2;


        StartCoroutine(Stand());


    }
}
