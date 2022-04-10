using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSpawn : MonoBehaviour
{
    [SerializeField] private GameObject chest;

    private void Start()
    {
        StartCoroutine(SpawnChest());
    }
    private void Repeat()
    {
        StartCoroutine(SpawnChest());
    }
    IEnumerator SpawnChest()
    {
        yield return new WaitForSeconds(30f);
        Vector3 v3Pos = new Vector3(Random.Range(-90f, 90f), Random.Range(-80f, 80f), 10f);
        Instantiate(chest, v3Pos, Quaternion.identity);
        Repeat();
    }
}
