using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField] private GameObject JumpS;
    [SerializeField] private GameObject AttackS;
    public float moveSpeed = 5f; // 플레이어 이동 속도
    public float JumpForce = 10f; //플레이어 점프 힘
    private int JumpCount = 0;
  

    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public Sprite dust;

    private Rigidbody2D rb;
    public Animator animator;

   

    private void Awake()
    {
        JumpS.SetActive(false);
        AttackS.SetActive(false);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        animator.SetBool("isGrounded", isGrounded);

        if(isGrounded == true)
        {
            JumpCount = 0;
        }
        

        // 오른쪽으로 이동
       // rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        if(Input.GetMouseButtonDown(1)&&JumpCount<2)
        {
            StartCoroutine(JumpSound());
            JumpCount++;
            
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, JumpForce));
        }
        else if (Input.GetMouseButtonUp(1) && rb.velocity.y > 0)
        {
            rb.velocity = rb.velocity * 0.5f;           //나누기는 연산값이 더 많이 나가기 때문에
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = dust;
        }

        //Attack
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(AttackSound());
            animator.SetTrigger("Attack");

        }

        animator.SetFloat("Speed", Mathf.Abs(moveSpeed));
    }

    private IEnumerator AttackSound()
    {
        AttackS.SetActive(true);
        yield return new WaitForSeconds(1f);
        AttackS.SetActive(false);
    }
    private IEnumerator JumpSound()
    {
        JumpS.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        JumpS.SetActive(false);
    }


}
