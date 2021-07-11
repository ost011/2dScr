using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    [SerializeField]
    private StageData stageData;
    [SerializeField]
    private GameObject alertLinePrefab;
    [SerializeField]
    private GameObject meteorPrefab;
    [SerializeField]
    private float minSpawnTime = 1.0f;
    [SerializeField]
    private float maxSpawnTime = 4.0f;

    private void Awake()
    {
        StartCoroutine("MeteorSpawn");
    }
    private IEnumerator MeteorSpawn()
    {
        while (true)
        {
            // y위치는 스테이지의 크기 범위 내에서 임의의 값을 선택
            float positionY = Random.Range(stageData.LimitMin.y, stageData.LimitMax.y);
            // 경고선 오브젝트 생성
            GameObject alertLineClone = Instantiate(alertLinePrefab, new Vector3(0, positionY, 0), Quaternion.identity);
            
            //1초간 대기
            yield return new WaitForSeconds(1.0f);

            //경고선 오브젝트 삭제
            Destroy(alertLineClone);

            //메테오 오브젝트 생성
            Vector3 meteorPosition = new Vector3(stageData.LimitMax.x + 1.0f, positionY, 0);
            Instantiate(meteorPrefab, meteorPosition, Quaternion.identity);

            //대기 시간 설정 (minSpawnTime ~ maxSpawnTime)
            float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            //해당 시간만큼 대기 후 다음 로직 실행
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
