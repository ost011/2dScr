using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosion;
    [SerializeField]
    private float damage = 1f;                 // �� ���ݷ�
    [SerializeField]
    private int scorePoint = 1;                // �� óġ�� ȹ�� ����
    private PlayerController playerController; // �÷��̾��� ���� ������ �����ϱ� ����

    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //������ �ε��� ������Ʈ�� �±װ� "Player"�̸�
        if (collision.tag == ("Player"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            // �� ����� ȣ��Ǵ� �Լ�
            OnDie();
        }
    }
    public void OnDie()
    {
        //�÷��̾��� ������ scorePoint��ŭ ����
        playerController.Score += scorePoint;
        //�� ������Ʈ ����
        Destroy(gameObject);
    }
}
/*
File : Enemy.cs
Desc : �� ĳ���� ������Ʈ�� �����ؼ� ���
*/
