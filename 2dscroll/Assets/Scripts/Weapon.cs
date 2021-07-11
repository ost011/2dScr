using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab; // ������ �� �����Ǵ� �߻�ü ������
    [SerializeField]
    private float attackRate = 0.15f;

    public void StartFiring()
    {
        StartCoroutine("TryAttack");
    }
    public void StopFiring()
    {
        StopCoroutine("TryAttack");
    }
    private IEnumerator TryAttack()
    {
        while (true)
        {
            //�߻�ü ������Ʈ ����
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            //attackRate �ð���ŭ ���
            yield return new WaitForSeconds(attackRate);
        }
    }
}
