using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public GameObject explosion;
    [SerializeField]
    private float damage = 2f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //������ �ε��� ������Ʈ�� �±װ� "Player"�̸�
        if (collision.tag == ("Player"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            // �� ���
            Destroy(this.gameObject);
        }
    }
}
