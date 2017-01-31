using UnityEngine;

public class SoundDamage : MonoBehaviour 
{
	public float damageBase = 1f;
	public float damageMultiplier = 1f;
	public int hitTimes = 3;

	PolishText polishText;
	float timer = 0f;

	void Awake()
	{
		polishText = GameObject.FindGameObjectWithTag("GameController").GetComponentInChildren<PolishText>();
	}

	void Start()
	{
		Destroy(gameObject, 5f);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Enemy")
		{
			float damage = 0f;

			if( col.gameObject.GetComponent<EnemyKind>().enemyProps.isLight )
				damage = damageBase * damageMultiplier;

			GameObject tmpText = polishText.SearchText();
			tmpText.GetComponent<TextMesh>().text = "" + damage;
			tmpText.gameObject.SetActive(true);
			Vector3 tmpPos = new Vector3(col.transform.position.x,
										 col.transform.position.y,
										 -1f);
			tmpText.transform.position = tmpPos;
			col.gameObject.GetComponent<EnemyKind>().enemyProps.HP -= damage;

			hitTimes--;

			if(hitTimes <= 0)
				Destroy(gameObject);
		}


		if(col.gameObject.tag == "Shot")
		{
			Destroy(col.gameObject);
		}

	}
}