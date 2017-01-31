using UnityEngine;

public class BossPath : MonoBehaviour 
{
	public static bool boss = false;

	EnemyKind enemyKind;
	PathController pathController;

	public GameObject shot;
	public float shotTime;

	int i = 0;

	float dabliu = 0.01f;
	float timer = 0f;

	void Awake()
	{
		enemyKind = GetComponent<EnemyKind>();

		pathController = GameObject.Find("Path_00").GetComponent<PathController>();
	}


	void Update()
	{
		timer += Time.deltaTime;

		if(timer > shotTime)
		{
			Instantiate(shot, transform.position, Quaternion.identity);
			timer = 0;
		}

		Vector3 pos = transform.position;
		pos = Vector3.MoveTowards(transform.position, pathController.nodes[i].position, enemyKind.enemyProps.speed * Time.deltaTime);
		transform.position = pos;

		if( (Vector3.Distance( transform.position, pathController.nodes[i].position ) < dabliu))
		{
			i++;

			if(i >= pathController.nodes.Count)
				i = 1;
		}	
	}
}