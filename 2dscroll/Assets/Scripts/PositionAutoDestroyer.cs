using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAutoDestroyer : MonoBehaviour
{
    [SerializeField]
    private StageData stageData;
    private float destroyweight = 2f;

    private void LateUpdate()
    {
        if(transform.position.x < stageData.LimitMin.x - destroyweight ||
            transform.position.x > stageData.LimitMax.x + destroyweight ||
            transform.position.y < stageData.LimitMin.y - destroyweight ||
            transform.position.y > stageData.LimitMax.y + destroyweight)
        {
            Destroy(gameObject);
        }
    }
}
/*
 file : PositionAutoDestroyer.cs
Desc : ȭ�� ������ ���� �� �ִ� ������Ʈ�� �����ؼ� ���
 : ������Ʈ�� ���� ���� �ٱ����� ������ ����
 */