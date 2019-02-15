using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour {

    private Vector3 startPoint;
    private int atk;

    private void Start()
    {
        startPoint = transform.position;
    }

    private void Update()
    {
        if ((transform.position - startPoint).magnitude > 10)
        {
            Destroy(gameObject, 0.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerMovement>().BeAttacked(atk);
            Destroy(gameObject, 0.0f);
        }
    }

    public void SetBulletAtk(int atk)
    {
        this.atk = atk;
    }
}
