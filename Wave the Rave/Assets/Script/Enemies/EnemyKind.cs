using UnityEngine;

public class EnemyKind : MonoBehaviour 
{
		public Enemies enemyProps;

		Struct enemyStructs;

		void Awake()
		{
			enemyStructs = GameObject.FindGameObjectWithTag("GameController").GetComponentInChildren<Struct>();
		}
}