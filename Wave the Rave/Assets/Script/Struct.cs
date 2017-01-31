using UnityEngine;

[System.Serializable]
public struct Enemies
{
	public float HP;
	public bool isDark;
	public bool isLight;
	public bool bothEle;
	public float speed;
	public float xp;
	public int lvl;
}

[System.Serializable]
public struct MonsterPack
{
	public int waveMonsters;
	public GameObject[] monsters;
}

[System.Serializable]
public struct Waves
{
	public MonsterPack[] monstersPacks;
}

[System.Serializable]
public struct PlayerProps
{
	public int lightEnergy;
	public int darkEnergy;
}

public class Struct : MonoBehaviour 
{
	public Enemies[] enemies;
	//public MonsterPack[] monstersPacks;
	public Waves[] waves;
	public PlayerProps playerProps;
}