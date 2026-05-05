using Unity.VisualScripting;
using UnityEngine;

public class RangedEnemyAttack : MonoBehaviour
{
    public GameObject enemyBullet;
    public GameObject player;
    public int timeBetweenShots = 2;
    public float time;
    public float rotationMultiplyer = 1f;
    public float speed;
    public float rotationModifier;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.Find("Player");
        GameObject enemyBullet = Instantiate(Resources.Load("EnemyBullet", typeof(GameObject))) as GameObject;

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > timeBetweenShots)
        {
            enemyBullet = Instantiate(enemyBullet, transform.position, transform.rotation);
           

    

   
    
          if (player != null)
          {
            Vector3 vectorToTarget = player.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            enemyBullet.transform.rotation = Quaternion.Slerp(enemyBullet.transform.rotation, q, Time.deltaTime * speed);
          }

    

          time = 0;
        }

    }
}
