using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
    public void MoveTo(Vector3 direction)
    {
        moveDirection = direction;
    }
}
/*
    File : Movement2D.cs
    Desc : �̵��� ������ ��� ������Ʈ���� ����

    Fuction : MoveTo() - �ܺο��� ȣ���� �̵� ������ ����

    */