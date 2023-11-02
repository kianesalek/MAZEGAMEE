using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public Transform respawnPoint;
    private bool isPlayerAlive = true;

    private void OnTriggerEnter(Collider other)
    {
        if (isPlayerAlive && other.CompareTag("Enemy"))
        {
            isPlayerAlive = false;
            StartCoroutine(RespawnPlayer());
        }
    }

    private IEnumerator RespawnPlayer()
    {
        yield return new WaitForSeconds(0f);

        transform.position = respawnPoint.position;
        isPlayerAlive = true;

    }
}