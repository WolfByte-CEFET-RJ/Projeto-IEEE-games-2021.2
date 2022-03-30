using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesShoot : EnemyMovement
{
    [SerializeField] List<EnemyMovement> enemies = new List<EnemyMovement>();
    [SerializeField] private float triggerTime;
    private int enemyNumber = 0;

    [SerializeField] private Tirinho shootObject;


    void Update()
	{
		triggerTime += Time.deltaTime;

		if (triggerTime >= 2)
		{
            enemyNumber = Random.Range(0, enemies.Count);
            Shoot(enemies[enemyNumber].FirePosition);
            triggerTime = 0;
		}
        
    }
    void Shoot(Transform firePosition)
    {
        Instantiate(shootObject.gameObject, firePosition.position, firePosition.rotation);
    }
}