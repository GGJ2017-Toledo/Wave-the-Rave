using UnityEngine;

public class EnemyPath : MonoBehaviour 
{
	EnemyKind enemyKind;
	PathController pathController;

	int num1,
		num2;

	string pathName;

	int i = 0;

	float dabliu = 0.01f;

	void Awake()
	{
		enemyKind = GetComponent<EnemyKind>();

		num1 = Random.Range(0, 7);
		num2 = Random.Range(1, 4);

		pathName = "Path_" + num1 + num2;

		pathController = GameObject.Find(pathName).GetComponent<PathController>();
	}

	void Update()
	{
		Vector3 pos = transform.position;
		pos = Vector3.MoveTowards(transform.position, pathController.nodes[i].position, enemyKind.enemyProps.speed * Time.deltaTime);
		transform.position = pos;

		if( (Vector3.Distance( transform.position, pathController.nodes[i].position ) < dabliu)  && ( i <= pathController.nodes.Count - 2) )
			i++;
	}
}