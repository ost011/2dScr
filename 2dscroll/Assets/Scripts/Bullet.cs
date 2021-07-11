using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 발사체에 부딪힌 오브젝트의 태그가 "Enemy"이면
        if (collision.tag == ("Enemy"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            //부딪힌 오브젝트 사망처리(적)
            collision.GetComponent<Enemy>().OnDie();
            //발사체 삭제
            Destroy(this.gameObject);
        }
    }
}
/*
 file : bullet.cs
desc : 플레이어 캐릭터의 공격 발사체
 */
