using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private GameObject player;
    public GameObject bullet;
    private GameObject myBullet;

    private float shootingCooltime = 60.0f;
    private float shootingTimer = 0;
    private float shootingIntervalSpeed = 1.0f;

    private void Update()
    {
        if (shootingTimer <= 0)
        {
            player = GameObject.FindWithTag("Player");
            if (player)
            {
                myBullet = Instantiate(bullet, transform.position, Quaternion.identity);
                myBullet.GetComponent<BulletMovement>().SetDirection((player.transform.position - transform.position).normalized, 5);
                myBullet.GetComponent<BulletEnemy>().SetBulletAtk(10);
                shootingTimer = shootingCooltime;
            }
        }

        shootingTimer -= shootingIntervalSpeed;
    }

}
