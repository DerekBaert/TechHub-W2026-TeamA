using Unity.VisualScripting;
using UnityEngine;

public class RangedEnemyAttack : MonoBehaviour
{
    public GameObject enemyBullet;
    public GameObject player;
    public int timeBetweenShots = 2;
    private float time;
    Vector3 rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.Find("Player");
     

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Vector2 direction = player.transform.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
        if (time > timeBetweenShots)
        {
            enemyBullet = Instantiate(enemyBullet, transform.position, transform.rotation);
            time = 0;
        }

    }
}
