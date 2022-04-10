using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject[] skills;
    private float waitingTimeLighting = 4f;
    private float waitingTimeDark = 8f;
    private float timer1 = 0f;
    private float timer2 = 0f;
    private void Update()
    {
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (timer1 > waitingTimeLighting - (Spells.lightingDelay + ChestParameters.hoodLVL) && Spells.isLighting == 1)
        {
            timer1 = 0f;
            Instantiate(skills[0], transform.position, transform.rotation);
        }
        if (timer2 > waitingTimeDark - (Spells.darkDelay + ChestParameters.hoodLVL) && Spells.isDark == 1)
        {
            timer2 = 0f;
            Instantiate(skills[1], transform.position, transform.rotation);
        }
    }
}
