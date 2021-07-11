using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private StageData stageData;        // �� ������ ���� �������� ũ�� ����
    [SerializeField]
    private GameObject enemyPrefab;     // �����ؼ� ������ �� ĳ���� ������
    [SerializeField]
    private float spawnTime;            // ���� �ֱ�

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }
    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            // y ��ġ�� ���������� ũ�� ���� ������ ������ ���� ����
            float positionY = Random.Range(stageData.LimitMin.y, stageData.LimitMax.y);
            //�� ĳ���� ����
            Instantiate(enemyPrefab, new Vector3(stageData.LimitMax.x + 1.0f,positionY , 0f), Quaternion.identity);
            // spawnTime��ŭ ���
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
