using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private Animator anim;
    private Vector3 TPosition;
    private bool isMoving = false;
    private bool looksRight;
    public Image deathPanel;
    [SerializeField] private SpriteRenderer sr;
    private float timer = 0f;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            TriggerPosition();
        }
        if (isMoving)
        {
            ItsMove();
            anim.SetBool("Move", true);
        }
        else if (isMoving == false)
        {
            anim.SetBool("Move", false);
        }
        if (PlayerHP.HP <= 0)
        {
            anim.SetBool("Death", true);
            speed = 0; 
            timer += Time.deltaTime;
            if (timer > 1f)
            {
                PlayerXP.LVL = 1;
                deathPanel.gameObject.SetActive(true);
                if (timer > 4 )
                {
                    Time.timeScale = 0;
                }
            }
        }
    }
    void TriggerPosition()
    {
        TPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        TPosition.z = transform.position.z;

        isMoving = true;

        if (TPosition.x < transform.position.x && !looksRight)
        {
            sr.flipX = true;
            looksRight = !looksRight;
        }
        if (TPosition.x > transform.position.x && looksRight)
        {
            sr.flipX = false;
            looksRight = !looksRight;
        }
    }
    void ItsMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, TPosition, (speed + ChestParameters.bootsLVL) * Time.deltaTime);

        if (transform.position == TPosition)
        {
            isMoving = false;
        }
    }
}
