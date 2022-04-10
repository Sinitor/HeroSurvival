using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{ 
    public GameObject[] prefabs;
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnStrongEnemy());
        StartCoroutine(MiniBoss());
        StartCoroutine(SpawnDemolLord());
        StartCoroutine(SpawnMummy());
    }
    private void Repeat()
    {
        StartCoroutine(SpawnEnemy());
    }
    private void RepeatStrong()
    {
        StartCoroutine(SpawnStrongEnemy());
    }
    private void RepeatMiniBoss()
    {
        StartCoroutine(MiniBoss());
    }
    private void RepeatDemonLord()
    {
        StartCoroutine(SpawnDemolLord());
    }
    private void RepeatMummy()
    {
        StartCoroutine(SpawnMummy());
    }
    IEnumerator SpawnEnemy()

    {
        yield return new WaitForSeconds(1.5f);
        Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-1.2f, 1.2f), Random.Range(-1.3f, 1.3f), 10f));
        Instantiate(prefabs[Random.Range(0, 2)], v3Pos, Quaternion.identity); 
        Repeat();
    }
    IEnumerator SpawnStrongEnemy()

    {
        yield return new WaitForSeconds(3f);
        Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-1.2f, 1.2f), Random.Range(-1.3f, 1.3f), 10f));
        Instantiate(prefabs[Random.Range(2, 4)], v3Pos, Quaternion.identity);
        RepeatStrong();
    }
    IEnumerator MiniBoss()

    {
        yield return new WaitForSeconds(20f);
        Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-1.2f, 1.2f), Random.Range(-1.3f, 1.3f), 10f));
        Instantiate(prefabs[4], v3Pos, Quaternion.identity);
        RepeatMiniBoss();
    }

    IEnumerator SpawnDemolLord()

    {
        yield return new WaitForSeconds(50f);
        Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-1.2f, 1.2f), Random.Range(-1.3f, 1.3f), 10f));
        Instantiate(prefabs[5], v3Pos, Quaternion.identity);
        RepeatDemonLord();
    }

    IEnumerator SpawnMummy()

    {
        yield return new WaitForSeconds(80f);
        Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-1.2f, 1.2f), Random.Range(-1.2f, 1.2f), 10f));
        Instantiate(prefabs[6], v3Pos, Quaternion.identity);
        RepeatMummy();
    }
}
