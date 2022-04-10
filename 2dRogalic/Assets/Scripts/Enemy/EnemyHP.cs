using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public float health;
    public float attack;
    public float enemyXP;
    private float clearAttack;
    [SerializeField] private Animator anim;
    private void Start()
    {
        health += PlayerXP.LVL / 2;
        attack += PlayerXP.LVL / 2;
        clearAttack = attack - (PlayerHP.armor + ChestParameters.armorLVL);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LightingSpell")
        {
            health -= 5 + (Spells.lightingDMG + ChestParameters.ringLVL);
            anim.SetBool("Damage", true);
        }
        if (collision.gameObject.tag == "Toxic")
        {
            health -= 8 + (Spells.lightingDMG + ChestParameters.ringLVL);
            anim.SetBool("Damage", true);
        }
        if (collision.gameObject.tag == "FireBall")
        {
            health -= 4 + (Spells.fireballDMG + ChestParameters.ringLVL);
            anim.SetBool("Damage", true);
        }
        if (collision.gameObject.tag == "ToxicBall")
        {
            health -= 6 + (Spells.fireballDMG + ChestParameters.ringLVL);
            anim.SetBool("Damage", true);
        }
        if (collision.gameObject.tag == "DarkMagic")
        {
            health -= 10 + (Spells.darkDMG + ChestParameters.ringLVL);
            anim.SetBool("Damage", true);
        }
        if (collision.gameObject.tag == "Holy")
        {
            health -= 5 + (Spells.lightingDMG + ChestParameters.ringLVL);
            anim.SetBool("Damage", true);
        }
        if (health <= 0)
        {
            PlayerXP.XP += enemyXP;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "PlayerHealth")
        {
            anim.SetBool("Attack", true);
            PlayerHP.HP -= clearAttack;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerHealth")
        {
            anim.SetBool("Attack", false);
        }
        if (collision.gameObject.tag == "LightingSpell" || collision.gameObject.tag == "Toxic" || collision.gameObject.tag == "FireBall" 
            || collision.gameObject.tag == "ToxicBall" || collision.gameObject.tag == "DarkMagic" || collision.gameObject.tag == "Holy")
        {
            anim.SetBool("Damage", false);
        }
    }
}
