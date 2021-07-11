using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StageData : ScriptableObject
{
    [SerializeField]
    private Vector2 limitMin;
    [SerializeField]
    private Vector2 limitMax;

    public Vector2 LimitMin => limitMin;
    public Vector2 LimitMax => limitMax;
   
}
/*
   File : StageData.cs
   Dexc : ���� ���������� ȭ�� �� ����
    : ���� �����ͷ� �����صΰ� ������ �ҷ��ͼ� ���
   ScriptableObject�� ���� �����͸� ������ �� �ִ� Ŭ����
   - ���ӿ� ���Ǵ� �����͸� �����صΰ� ���� �߰��� �ҷ����� ����
   (������ / ��ų ������, ���� �� ������, �� ���̿� �����Ǵ� ������)
   */