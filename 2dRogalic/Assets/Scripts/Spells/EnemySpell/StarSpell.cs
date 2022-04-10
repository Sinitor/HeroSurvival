using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpell : MonoBehaviour
{
    private float attack;
    private float clearAttack;
    private void Start()
    {
        attack = 15 + PlayerXP.LVL / 2;
        clearAttack = attack - (PlayerHP.armor + ChestParameters.armorLVL);
        StartCoroutine(Death());
    }
    IEnumerator Death()

    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerHealth")
        {
            PlayerHP.HP -= clearAttack;
        }
    }
}
