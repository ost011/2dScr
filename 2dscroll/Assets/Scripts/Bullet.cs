using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �߻�ü�� �ε��� ������Ʈ�� �±װ� "Enemy"�̸�
        if (collision.tag == ("Enemy"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            //�ε��� ������Ʈ ���ó��(��)
            collision.GetComponent<Enemy>().OnDie();
            //�߻�ü ����
            Destroy(this.gameObject);
        }
    }
}
/*
 file : bullet.cs
desc : �÷��̾� ĳ������ ���� �߻�ü
 */
