using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float xInput;
    public float yInput;
    public float moveSpeed;
    public float jumpForce;
    private Animator anim;

    [SerializeField]
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        anim =GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Movement();

        CheckInput();

        AnimatorController();
    }

    private void CheckInput()
    {
        //GetAxis 只有值 -1 0 1
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Movement()
    {
        rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void AnimatorController()
    {
        bool isMoving = xInput != 0;
        anim.SetBool("isMoving", isMoving);
    }
}
