using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionScroller : MonoBehaviour
{
    [SerializeField]
    private Transform target; // 현재 게임에서는 두개의 배경이 서로가 서로의 타겟
    [SerializeField]
    private float scrollRange = 18.4f;
    [SerializeField]
    private float moveSpeed = 3.0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.left; // or down;

    private void Update()
    {
        //배경이 moveDirection 방향으로 moveSpeed의 속도로 이동
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        //배경이 설정된 범위를 벗어나면 위치 재설정
        if(transform.position.x <= -scrollRange)
        {
            transform.position = target.position + Vector3.right * scrollRange;
        }
    }
}
/*
File : PositionScroller.cs
Desc : 스크롤 시키고 싶은 오브젝트에 부착해서 사용

*/