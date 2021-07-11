using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScoreViewer : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;
    private TextMeshProUGUI textScore;

    private void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        //Text UI ���� ���� ������ ������Ʈ
        textScore.text = "Score " + playerController.Score;
    }
}
/*
 * File : PlayerScoreViewer.cs
 * Desc : �÷��̾��� ���� ������ Text UI�� ������Ʈ
 * 
 */