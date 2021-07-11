using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private float maxHp = 5f;
    private float currentHp;
    private SpriteRenderer spriteRenderer;
    private PlayerController playerController;

    public float MaxHP => maxHp;        // maxHP ������ ������ �� �ִ� ������Ƽ(Get�� ����)
    public float CurrentHP => currentHp;// currentHp ������ ������ �� �ִ� ������Ƽ(Get�� ����)

    private void Awake()
    {
        currentHp = maxHp;
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
    }
    public void TakeDamage(float damage)
    {
        //���� ü���� Damage��ŭ ����
        currentHp -= damage;

        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");

        //ü���� 0���� = �÷��̾� ���
        if(currentHp <=0f)
        {
            // ü���� 0�̸� OnDie() �Լ��� ȣ���ؼ� �׾��� �� ó��
            playerController.OnDie();
        }
    }
    private IEnumerator HitColorAnimation()
    {
        //�÷��̾� ������ ����������
        spriteRenderer.color = Color.red;
        //0.1�� ���� ���
        yield return new WaitForSeconds(0.1f);
        //�÷��̾��� ������ ���� ������ �Ͼ������
        //(���� ������ �Ͼ���� �ƴ� ��� ���� ���� ���� ����)
        spriteRenderer.color = Color.white;
    }
}
