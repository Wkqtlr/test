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
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0); // 벡터 값
        transform.Translate(vec); //백터값으로 이동
    }

}
    /*
    //게임 오브젝트 생성할때, 최초 실행
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다");
    }
    //게임 오브젝트가 활성화 되었을때
    void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }
    //게임 로직 업데이트(컴퓨터 환경에 따라 주기가 달리짐)
    void Update()
    {
        //게임 내 입력을 관리하는 클래스 
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
            //GetAxis : 수평, 수직 버튼 입력을 받으면 float
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));
        }
    }
    
        if (Input.GetKeyDown(KeyCode.Return)) // enter랑 똑같다
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow)) //getkey : 키보드 버튼 입력시 true
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");

    //업데이트 시작 직전, 최초 실행
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
    //물리 연산 업데이트(고정된 주기로 꾸준히 cpu를 많이 사용)
    void FixedUpdate()
    {
        Debug.Log("이동~");
    }

    //모든 업데이트 끝난 후
    void LateUpdate()
    {
        Debug.Log("경험치 획득.");
    }
    //게임오브젝트가 비활성화 되었을 때
    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }
    //게임 오브젝트가 삭제될때(마지막으로 출력)
    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
    */
