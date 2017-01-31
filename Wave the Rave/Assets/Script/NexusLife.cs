using UnityEngine;
using UnityEngine.UI;

public class NexusLife : MonoBehaviour 
{
	public Button restButton;

	public float life = 100f;
	public Light light;
	CircleCollider2D colider;
	public Light light1, light2, light3, light4;
	public GameObject obj1,obj2, obj3, obj4;

	void Start ()
	{
		colider = GetComponent<CircleCollider2D>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Enemy")
		{
			float EnemyLife = col.gameObject.GetComponent<EnemyKind>().enemyProps.HP;
			life -= EnemyLife;
			Died.Die();
			Destroy(col.gameObject);
		}

		if(col.gameObject.tag == "Shot")
		{
			life -= 10f;
			Destroy(col.gameObject);
		}
	}

	void Update()
	{
		light.intensity = life * 0.08f;
		light1.intensity = life * 0.08f;
		light2.intensity = life * 0.08f;
		light3.intensity = life * 0.08f;
		light4.intensity = life * 0.08f;

		if(life <= 0)
		{
			//restButton.gameObject.SetActive(true);
			Application.LoadLevel(3);
			Destroy(this.gameObject);
			Destroy(obj1);
			Destroy(obj2);
			Destroy(obj3);
			Destroy(obj4);
		}
	}
}