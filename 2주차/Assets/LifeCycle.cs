using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0); // ���� ��
        transform.Translate(vec); //���Ͱ����� �̵�
    }

}
    /*
    //���� ������Ʈ �����Ҷ�, ���� ����
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�");
    }
    //���� ������Ʈ�� Ȱ��ȭ �Ǿ�����
    void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }
    //���� ���� ������Ʈ(��ǻ�� ȯ�濡 ���� �ֱⰡ �޸���)
    void Update()
    {
        //���� �� �Է��� �����ϴ� Ŭ���� 
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));
            //GetAxis : ����, ���� ��ư �Է��� ������ float
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));
        }
    }
    
        if (Input.GetKeyDown(KeyCode.Return)) // enter�� �Ȱ���
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow)) //getkey : Ű���� ��ư �Է½� true
            Debug.Log("�������� �̵� ��");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵��� ���߾����ϴ�.");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");

    //������Ʈ ���� ����, ���� ����
    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }
    //���� ���� ������Ʈ(������ �ֱ�� ������ cpu�� ���� ���)
    void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }

    //��� ������Ʈ ���� ��
    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��.");
    }
    //���ӿ�����Ʈ�� ��Ȱ��ȭ �Ǿ��� ��
    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }
    //���� ������Ʈ�� �����ɶ�(���������� ���)
    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
    */
