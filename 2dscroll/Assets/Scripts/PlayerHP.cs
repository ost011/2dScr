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

    public float MaxHP => maxHp;        // maxHP 변수에 접근할 수 있는 프로퍼티(Get만 가능)
    public float CurrentHP => currentHp;// currentHp 변수에 접근할 수 있는 프로퍼티(Get만 가능)

    private void Awake()
    {
        currentHp = maxHp;
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
    }
    public void TakeDamage(float damage)
    {
        //현재 체력을 Damage만큼 감소
        currentHp -= damage;

        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");

        //체력이 0이하 = 플레이어 사망
        if(currentHp <=0f)
        {
            // 체력이 0이면 OnDie() 함수를 호출해서 죽었을 때 처리
            playerController.OnDie();
        }
    }
    private IEnumerator HitColorAnimation()
    {
        //플레이어 색상을 빨간색으로
        spriteRenderer.color = Color.red;
        //0.1초 동안 대기
        yield return new WaitForSeconds(0.1f);
        //플레이어의 색상을 원래 색상인 하얀색으로
        //(원래 색상이 하얀색이 아닐 경우 원래 색상 변수 선언)
        spriteRenderer.color = Color.white;
    }
}
