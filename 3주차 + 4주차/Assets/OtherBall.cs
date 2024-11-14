using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh; //������Ʈ ���� ����
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }


    private void OnCollisionEnter(Collision collision) //������ �浹�� �����Ҷ� ȣ��Ǵ� �Լ� //collision�� �浹 ���� Ŭ����
    {
        if (collision.gameObject.name == "My Ball")
        {
            mat.color = new Color(0, 0, 0);
        }
    }

    private void OnCollisionEnterExit(Collision collision) //������ �浹�� ���� ������ ȣ��Ǵ� �Լ�
    {
        if (collision.gameObject.name == "My Ball")
        {
            mat.color = new Color(1, 1, 1);
        }
    }
    /*
    private void OnCollisionStay(Collision collision) //������ �浹�ϴ� ��
    {
        
    
    */
}
