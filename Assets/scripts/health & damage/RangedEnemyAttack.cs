using Unity.VisualScripting;
using UnityEngine;

public class RangedEnemyAttack : MonoBehaviour
{
    public GameObject enemyBullet;
    public GameObject player;
    public int timeBetweenShots = 2;
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.Find("Player");
        GameObject.Find("EnemyBullet");
       
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > timeBetweenShots)
        {
            enemyBullet = Instantiate(enemyBullet, transform.position, transform.rotation);
            enemyBullet.transform.rotation = Quaternion.Euler(0, enemyBullet.transform.rotation.eulerAngles.y, 0); 
            enemyBullet.transform.LookAt(player.transform, Vector3.up);
            
            time = 0;
        }

    }
}
