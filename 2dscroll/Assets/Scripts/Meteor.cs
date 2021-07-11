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
        //적에게 부딪힌 오브젝트의 태그가 "Player"이면
        if (collision.tag == ("Player"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            // 적 사망
            Destroy(this.gameObject);
        }
    }
}
