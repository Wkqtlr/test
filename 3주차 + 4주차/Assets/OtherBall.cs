using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh; //오브젝트 재질 접근
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }


    private void OnCollisionEnter(Collision collision) //물리적 충돌이 시작할때 호출되는 함수 //collision은 충돌 정보 클래스
    {
        if (collision.gameObject.name == "My Ball")
        {
            mat.color = new Color(0, 0, 0);
        }
    }

    private void OnCollisionEnterExit(Collision collision) //물리적 충돌이 끝이 났을때 호출되는 함수
    {
        if (collision.gameObject.name == "My Ball")
        {
            mat.color = new Color(1, 1, 1);
        }
    }
    /*
    private void OnCollisionStay(Collision collision) //물리적 충돌하는 중
    {
        
    
    */
}
