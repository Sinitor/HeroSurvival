using UnityEngine;

public class DemonFire : MonoBehaviour
{
    private float attack;
    private float clearAttack;
    private void Start()
    {
        attack = 15 + PlayerXP.LVL / 2;
        clearAttack = attack - (PlayerHP.armor + ChestParameters.armorLVL);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerHealth")
        {
            PlayerHP.HP -= clearAttack;
        }
    }
}
