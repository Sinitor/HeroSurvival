using System.Collections;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerHealth")
        {  
            anim.SetBool("Idle", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerHealth")
        {
            gameObject.tag = "Untagged";
            StartCoroutine(Death());
        }
    }
    IEnumerator Death()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}
