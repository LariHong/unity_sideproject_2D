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
        //���`�� get key
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

        //�ϥ� GetButton �n�h unity���� edit > project settings > input manager > axes �M��
        if (Input.GetButton("Jump"))
        {
            Debug.Log("up");
        }

        //GetAxis �|�����ƭ� ���� -1~0~1
        //xInput = Input.GetAxis("Horizontal");
        //yInput = Input.GetAxis("Vertical");

        //GetAxis �u���� -1 0 1
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
    }
}
