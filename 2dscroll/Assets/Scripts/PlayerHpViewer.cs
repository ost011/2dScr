using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHpViewer : MonoBehaviour
{
    [SerializeField]
    private PlayerHP playerHP;
    private Slider sliderHP;

    private void Awake()
    {
        sliderHP = GetComponent<Slider>();
    }

    private void Update()
    {
        //Slider UI�� ���� ü�� ������ ������Ʈ
        sliderHP.value = playerHP.CurrentHP / playerHP.MaxHP;
    }
}
/*
 File : PlayerHpViewer.cs
 Desc : �÷��̾��� ü�� ������ Slider UI�� ������Ʈ
 
 */