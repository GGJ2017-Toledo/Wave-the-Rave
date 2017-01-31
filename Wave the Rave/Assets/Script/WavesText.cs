using UnityEngine;

public class WavesText : MonoBehaviour 
{
	public float speed;
	public float lifetime;

	float timer = 0f;

	void Update()
	{
		timer += Time.deltaTime;

		if(timer > lifetime)
			transform.position = transform.parent.position;

		if(timer <= lifetime)
			transform.Translate(Vector3.up * speed * Time.deltaTime);
	}

	public void CallText(string text)
	{
		gameObject.GetComponent<TextMesh>().text = text;
		timer = 0f;
	}
}