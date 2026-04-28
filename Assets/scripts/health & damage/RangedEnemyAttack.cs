using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class RangedEnemyAttack : MonoBehaviour
{
    public GameObject enemyBullet;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        enemyBullet = Instantiate(enemyBullet, transform.position, transform.rotation);
        enemyBullet.transform.LookAt(player.transform, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
