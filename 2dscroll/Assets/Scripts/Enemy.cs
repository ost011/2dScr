using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosion;
    [SerializeField]
    private float damage = 1f;                 // 적 공격력
    [SerializeField]
    private int scorePoint = 1;                // 적 처치시 획득 점수
    private PlayerController playerController; // 플레이어의 점수 정보에 접근하기 위해

    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //적에게 부딪힌 오브젝트의 태그가 "Player"이면
        if (collision.tag == ("Player"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            // 적 사망시 호출되는 함수
            OnDie();
        }
    }
    public void OnDie()
    {
        //플레이어의 점수를 scorePoint만큼 증가
        playerController.Score += scorePoint;
        //적 오브젝트 삭제
        Destroy(gameObject);
    }
}
/*
File : Enemy.cs
Desc : 적 캐릭터 오브젝트에 부착해서 사용
*/
