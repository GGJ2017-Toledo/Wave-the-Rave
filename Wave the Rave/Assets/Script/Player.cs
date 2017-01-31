using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour 
{
	public Text lightEssenceText;
	public Text soundEssenceText;
	public Text currentWave;
	public Text remainingEnemies;

	Struct structs;

	void Awake()
	{
		structs = GameObject.FindGameObjectWithTag("GameController").GetComponentInChildren<Struct>();
	}

	void Update()
	{
		lightEssenceText.text = "" + structs.playerProps.lightEnergy;
		soundEssenceText.text = "" + structs.playerProps.darkEnergy;
		remainingEnemies.text = "" + Respawner.monsterAmount;
		currentWave.text = "" + Respawner.currentWave;
	}
}