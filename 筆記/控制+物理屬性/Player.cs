using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float xInput;
    public float yInput;
    public float moveSpeed;
    public float jumpForce;
    [SerializeField]
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //正常的 get key
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("jump");
        //}
        //if(Input.GetKey(KeyCode.Space))
        //{
        //    Debug.Log("holded");
        //}
        //if(Input.GetKeyUp(KeyCode.Space))
        //{
        //    Debug.Log("up");
        //}

        //GetAxis 會有平滑值 接近 -1~0~1
        //xInput = Input.GetAxis("Horizontal");
        //yInput = Input.GetAxis("Vertical");

        //GetAxis 只有值 -1 0 1
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        ////使用 GetButton 要去 unity中的 edit > project settings > input manager > axes 尋找
        //if (Input.GetButton("Jump"))
        //{
        //    Debug.Log("up");
        //}

        rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        // 如果有水平输入，讓它滚动
        if (xInput != 0)
        {
            float torque = -xInput * 2; // 使用負號讓滚动方向正确
            rb.AddTorque(torque);
        }
        else
        {
            // 如果没有输入，停止角速度，立即停止滚动
            rb.angularVelocity = 0;
        }
    }
}
