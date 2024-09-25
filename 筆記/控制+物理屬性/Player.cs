using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float xInput;
    public float yInput;
    // Start is called before the first frame update
    void Start()
    {

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

        //使用 GetButton 要去 unity中的 edit > project settings > input manager > axes 尋找
        if (Input.GetButton("Jump"))
        {
            Debug.Log("up");
        }

        //GetAxis 會有平滑值 接近 -1~0~1
        //xInput = Input.GetAxis("Horizontal");
        //yInput = Input.GetAxis("Vertical");

        //GetAxis 只有值 -1 0 1
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
    }
}
