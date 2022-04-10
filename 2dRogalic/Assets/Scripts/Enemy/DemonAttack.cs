using UnityEngine;

public class DemonAttack : MonoBehaviour
{
    [SerializeField] private GameObject[] skills;
    private float waitingTimeLighting = 6f;
    private float timer = 0f;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitingTimeLighting)
        {
            timer = 0f;
            Instantiate(skills[0], transform.position, transform.rotation);
        }
    }
}
