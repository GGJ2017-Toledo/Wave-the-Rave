using UnityEngine;
using System.Collections.Generic;

public class PathController : MonoBehaviour 
{
	public Color rayColor = Color.white;
	public float sphereRadius = 1f;
	public List<Transform> nodes = new List<Transform>();
	Transform[] array;

	Vector3 pos;
	Vector3 previous;

	void OnDrawGizmos()
	{
		Gizmos.color = rayColor;

		array = GetComponentsInChildren<Transform> ();
		nodes.Clear ();

		foreach (Transform node in array) 
			if (node != this.transform) 
				nodes.Add (node);

		for(int i = 0; i < nodes.Count; i++)
		{
			pos = nodes[i].position;
			Gizmos.DrawWireSphere(pos, sphereRadius);
			if(i > 0)
			{
				previous = nodes[i-1].position;
				Gizmos.DrawLine(previous, pos);
			}
		}
	}
}