using UnityEngine;

public class Died : MonoBehaviour 
{
	EnemyKind enemyKind;
	Struct structs;

	void Awake()
	{
		enemyKind = GetComponent<EnemyKind>();
		structs = GameObject.FindGameObjectWithTag("GameController").GetComponentInChildren<Struct>();
	}

	void Update()
	{
		if(enemyKind.enemyProps.HP <= 0f)
		{
			int num = Random.Range(0, 10);
			if(num < 6)
			{
				if( enemyKind.enemyProps.isDark )
					structs.playerProps.darkEnergy++;
				else if( enemyKind.enemyProps.isLight )
					structs.playerProps.lightEnergy++;
				else
				{
					structs.playerProps.darkEnergy++;
					structs.playerProps.lightEnergy++;
				}
			}

			Die();

			Destroy(gameObject);
		}
	}

	public static void Die()
	{
		Respawner.monsterAmount--;
	}
}