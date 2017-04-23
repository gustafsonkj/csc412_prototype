using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepSpawn : MonoBehaviour
{
    public GameObject creep;
    public List<Transform> spawnPositions;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(spawnCreep());
    }

    //void startSpawning()
    //{
    //    StartCoroutine(spawnCreep());
    //}
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnCreep()
    {
        while(true)
        {
            int choice = Random.Range(0, spawnPositions.Count);
            Instantiate(creep, spawnPositions[choice].position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1f, 2f));

        }
        
    }
}
