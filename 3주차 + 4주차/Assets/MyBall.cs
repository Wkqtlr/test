using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(Vector3.up * 50, ForceMode.Impulse); //방향과 크기로 힘을 준다
    }

    void FixedUpdate()
    {
        //rigid.velocity = new Vector3(2, 4, -1); //1.속력 바꾸기

        /*
        if (Input.GetButtonDown("Jump")) //2. 힘을 가하지
        {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
        */
        //rigid.AddTorque(Vector3.down); //방향을 축으로 회전력이 생김

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }
}
