using UnityEngine;
public class GroundGenerate : MonoBehaviour
{
    public GameObject[] ground;

    private void Start()
    {
        int rand = Random.Range(0, ground.Length);
        Instantiate(ground[rand], transform.position, Quaternion.identity);
    }
}
