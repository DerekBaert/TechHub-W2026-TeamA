using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject playerBullet;
    public Transform firePoint;
    public float bulletSpeed = 50;
    public GameObject player;

    Vector2 lookDirection;
    float lookAngle;


    void Update()
    {
        
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - new Vector3 (player.transform.position.x, player.transform.position.y);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        firePoint.rotation = Quaternion.Euler(0, 0, lookAngle);

        if (Input.GetMouseButtonDown(0))
        {;
            GameObject bulletClone = Instantiate(playerBullet);
            bulletClone.transform.position = firePoint.position;
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletClone.GetComponent<Rigidbody2D>().linearVelocity = firePoint.right * bulletSpeed;


        }
    }
}
