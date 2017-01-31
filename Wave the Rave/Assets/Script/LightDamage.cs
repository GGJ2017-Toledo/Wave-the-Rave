using UnityEngine;

public class LightDamage : MonoBehaviour 
{
	public float damageBase = 1f;
	public float damageMultiplier = 1f;
	public float damageTime = 0.3f;

	PolishText polishText;
	float timer = 0f;

	void Awake()
	{
		polishText = GameObject.FindGameObjectWithTag("GameController").GetComponentInChildren<PolishText>();
	}

	void OnTriggerStay2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			timer += Time.deltaTime;
			float damage = 0;

			if(col.gameObject.GetComponent<EnemyKind>().enemyProps.isDark) 
				damage = damageBase * damageMultiplier;
											
			if(timer > damageTime)
			{
				GameObject tmpText = polishText.SearchText();
				tmpText.GetComponent<TextMesh>().text = "" + damage;
				tmpText.gameObject.SetActive(true);
				tmpText.gameObject.SetActive(true);
				Vector3 tmpPos = new Vector3(col.transform.position.x,
										 col.transform.position.y,
										 -1f);
				tmpText.transform.position = tmpPos;
				col.gameObject.GetComponent<EnemyKind>().enemyProps.HP -= damage;
				timer = 0f;
			}
		}

		if(col.gameObject.tag == "Shot")
		{
			Destroy(col.gameObject);
		}
	}
}