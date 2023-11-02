using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject endDoor;
    public GameObject[] spawnPoints;
    void Start()
    {
        int scrapInt = Random.Range(0, spawnPoints.Length);
        Instantiate(endDoor, spawnPoints[scrapInt].transform);
        Debug.Log("Prints DOOR");
    }

}
