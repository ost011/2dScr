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
   Dexc : 현재 스테이지의 화면 내 범위
    : 에셋 데이터로 저장해두고 정보를 불러와서 사용
   ScriptableObject는 공유 데이터를 저장할 수 있는 클래스
   - 게임에 사용되는 데이터를 저장해두고 게임 중간에 불러오기 가능
   (아이템 / 스킬 데이터, 게임 내 데이터, 씬 사이에 유지되는 데이터)
   */