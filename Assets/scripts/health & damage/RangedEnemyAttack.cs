using UnityEngine;

public class RangedEnemyAttack : MonoBehaviour
{
    public GameObject enemyBullet;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
        enemyBullet = Instantiate(enemyBullet, transform.position,transform.LookAt(player.transform,Vector3.));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
