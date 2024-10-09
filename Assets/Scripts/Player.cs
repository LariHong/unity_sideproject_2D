using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("角色操控")]
    [SerializeField]
    private LayerMask whatIsGround;
    [SerializeField]
    private float playerGroundDistance;
    [SerializeField]
    private bool isGround;
    private int playerFacing = 1;
    private bool playerFacingRight = true;
    [Header("角色Dash操控")]
    [SerializeField]
    private float dashSpeed;
    [SerializeField]
    private float dashDuration;
    [SerializeField]
    private float dashTime;
    [SerializeField]
    private float dashCooldown;
    [SerializeField]
    private float dashCooldownTimer;
    [Header("角色Attack操控")]
    private float comboTime=0.8f;
    private float comboTimeCounter;
    private bool isAttacking;
    private int comboCounter;

    [Header("角色物理")]
    public float xInput;
    public float yInput;
    public float moveSpeed;
    public float jumpForce;
    [SerializeField]
    private Rigidbody2D rb;

    [Header("角色動作")]
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Movement();
        JumpCheck();

        dashTime -= Time.deltaTime;
        dashCooldownTimer -= Time.deltaTime;
        comboTimeCounter -= Time.deltaTime;

        FlipController();
        AnimatorController();
    }

    private void JumpCheck()
    {
        isGround = Physics2D.Raycast(transform.position, Vector2.down, playerGroundDistance, whatIsGround);
    }

    #region 角色操控區
    private void CheckInput()
    {
        //GetAxis 只有值 -1 0 1
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.Q) )
        {
            Dash();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }

    private void Attack()
    {
        if (!isGround) return;

        if (comboTimeCounter < 0) comboCounter = 0;

        isAttacking = true;

        comboTimeCounter = comboTime;
    }

    public  void AttackOver()
    {
        isAttacking = false;

        comboCounter++;
        if ( comboCounter > 2 ) comboCounter = 0;
    }

    private void Dash()
    {
        if(dashCooldownTimer < 0 && !isAttacking)
        {
            dashCooldownTimer = dashCooldown;
            dashTime = dashDuration;
        }
    }

    private void Movement()
    {
        if (isAttacking)
        {
            rb.velocity = new Vector2(0, 0);
        }
        else if (dashTime > 0)
        {
            rb.velocity = new Vector2(playerFacing * dashSpeed, 0);
        }
        else
        {
            rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);
        }
    }

    private void Jump()
    {
        if (isGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    //角色的轉向設定
    private void Flip()
    {
        playerFacing = playerFacing * -1;
        playerFacingRight = !playerFacingRight;
        transform.Rotate(0, 180, 0);
    }
    private void FlipController()
    {
        if (rb.velocity.x > 0 && !playerFacingRight)
            Flip();
        else if (rb.velocity.x < 0 && playerFacingRight)
            Flip();
    }
    #endregion

    #region 角色動作區
    private void AnimatorController()
    {
        bool isMoving = xInput != 0;
        anim.SetFloat("yVelocity", rb.velocity.y);
        anim.SetBool("isMoving", isMoving);
        anim.SetBool("isGrounded", isGround);
        anim.SetBool("isDashing", dashTime > 0);
        anim.SetBool("isAttacking", isAttacking);
        anim.SetInteger("comboCounter", comboCounter);
    }
    #endregion

    #region 線條測試區
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y - playerGroundDistance));
    }
    #endregion
}
