using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private float _speedPlayer;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Movement();
    }

	private void Movement()
	{
		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");

		Vector3 direction = new Vector3(moveX, moveY, 0);

		transform.Translate(direction * _speedPlayer * Time.deltaTime);

		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9f, 0f), transform.position.y, 0);
	

		if (transform.position.y > 6.8f)
		{
			transform.position = new Vector3(transform.position.x, -5f, 0);
		}

		else if (transform.position.y < -5)
		{
			transform.position = new Vector3(transform.position.x, 6.8f, 0);
		}
	}
}
