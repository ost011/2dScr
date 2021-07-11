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
            // y��ġ�� ���������� ũ�� ���� ������ ������ ���� ����
            float positionY = Random.Range(stageData.LimitMin.y, stageData.LimitMax.y);
            // ��� ������Ʈ ����
            GameObject alertLineClone = Instantiate(alertLinePrefab, new Vector3(0, positionY, 0), Quaternion.identity);
            
            //1�ʰ� ���
            yield return new WaitForSeconds(1.0f);

            //��� ������Ʈ ����
            Destroy(alertLineClone);

            //���׿� ������Ʈ ����
            Vector3 meteorPosition = new Vector3(stageData.LimitMax.x + 1.0f, positionY, 0);
            Instantiate(meteorPrefab, meteorPosition, Quaternion.identity);

            //��� �ð� ���� (minSpawnTime ~ maxSpawnTime)
            float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            //�ش� �ð���ŭ ��� �� ���� ���� ����
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
