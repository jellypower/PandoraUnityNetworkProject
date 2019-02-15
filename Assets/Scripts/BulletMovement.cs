using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    Vector3 direction = Vector3.zero;
    float speed = 0.0f;

    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    public void SetDirection(Vector3 direction, float speed)
    {
        this.direction = direction;
        this.speed = speed;
    }
}
