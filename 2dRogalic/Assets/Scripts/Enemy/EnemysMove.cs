using System.Collections;
using UnityEngine;

public class EnemysMove : MonoBehaviour
{
    [SerializeField] float speed;
    private Transform target;
    private bool looksRight;
    [SerializeField] GameObject targetHP;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        if (target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step); 

            if (target.position.x < transform.position.x && !looksRight)
            {
                Flip();
            }
            if (target.position.x > transform.position.x && looksRight)
            {
                Flip();
            }
            StartCoroutine(Destroy());
        } 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            target = collision.transform;
        }
    }
    private void Flip()
    {
        looksRight = !looksRight;
        transform.Rotate(0, 180, 0);
    }   
    IEnumerator Destroy()
    {
        if (targetHP == null)
        {
            anim.SetBool("Des", true);
            speed = 0;
            yield return new WaitForSeconds(2);
            Destroy(gameObject);
        } 
    }
}
