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
Desc : 화면 밖으로 나갈 수 있는 오브젝트에 부착해서 사용
 : 오브젝트가 일정 범위 바깥으로 나가면 삭제
 */