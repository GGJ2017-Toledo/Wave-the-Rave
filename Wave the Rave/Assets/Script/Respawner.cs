using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour 
{
	public static int monsterAmount = 0;
	public static int currentLvl = 0;
	public static int currentWave = 0;

	public int respawnTime;

	Struct structs;
	EnemyKind enemyKind;
	WavesText wavesText;
	WavesText chapterText;

	GameObject[] monsters;

	List<GameObject> lista;
	int i = 0;
	float tempo = 0f;
	float timer = 0f;

	void Awake()
	{
		wavesText = GameObject.FindGameObjectWithTag("WaveText").GetComponent<WavesText>();
		chapterText = GameObject.FindGameObjectWithTag("ChapterText").GetComponent<WavesText>();

		lista = new List<GameObject>();

		structs = GameObject.FindGameObjectWithTag("GameController").GetComponentInChildren<Struct>();
		i = 0;
	}

	void Update()
	{
		InstantMonsters();

		if(monsterAmount <= 0)
		{
			timer += Time.deltaTime;

			if(timer > 2f)
			{
				NewLevel();
				wavesText.CallText("Wave " + currentWave);
				timer = 0;
			}
		}
	}

	void InstantMonsters()
	{
		if(i < lista.Count)
		{
			tempo += Time.deltaTime;

			if(tempo > respawnTime)
			{
				Instantiate(lista[i], transform.position, Quaternion.identity);
				i++;
				tempo = 0;
			}
		}
	}

	void NewLevel()
	{
		lista.Clear();

		monsters = structs.waves[currentLvl].monstersPacks[currentWave].monsters;

		while( i < structs.waves[currentLvl].monstersPacks[currentWave].waveMonsters)
		{
			int index = Random.Range(0, monsters.Length);

			lista.Add(monsters[index]);

			monsterAmount++;

			i += monsters[index].GetComponent<EnemyKind>().enemyProps.lvl;
		}

		i = 0;

		currentWave++;

		print(currentWave);
		if(currentWave >= structs.waves[currentLvl].monstersPacks.Length)
		{
			chapterText.CallText("Chapter " + currentLvl);
			currentLvl++;
			currentWave = 0;
		}
	}
}