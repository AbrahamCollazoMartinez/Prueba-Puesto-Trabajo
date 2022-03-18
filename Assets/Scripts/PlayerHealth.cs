using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]private PlayerMovement PM;
    bool Avaiable = true;

    WaitForSeconds Move_W = new WaitForSeconds(1f);
    WaitForSeconds Move_A = new WaitForSeconds(2f);

    private void OnTriggerEnter(Collider other)
    {
    

        if (other.CompareTag("Bullet_Enemy"))
        {
            HitPlayer();

        }

    }

    public void HitPlayer()
    {
        if (Avaiable)
        {
            Avaiable = false;
            PM.PlayerSpeed = 0;
            StartCoroutine(WaitToMove());
        }

    }

    IEnumerator WaitToMove()
    {
        yield return Move_W;
        PM.PlayerSpeed = 0.2f;
        StartCoroutine(AvaiableToHitAgain());

    }
    IEnumerator AvaiableToHitAgain()
    {

        yield return Move_A;
        Avaiable = true;

    }
}
