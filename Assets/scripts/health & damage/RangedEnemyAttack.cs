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
        GameObject enemyBullet = Instantiate(Resources.Load("EnemyBullet", typeof(GameObject))) as GameObject;

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > timeBetweenShots)
        {
            enemyBullet = Instantiate(enemyBullet, transform.position, transform.rotation);
            Vector3 targ = player.transform.position;
            targ.z = 0f;

            Vector3 objectPos = enemyBullet.transform.position;
            targ.x = targ.x - objectPos.x;
            targ.y = targ.y - objectPos.y;

            float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
            enemyBullet.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            time = 0;
        }

    }
}
