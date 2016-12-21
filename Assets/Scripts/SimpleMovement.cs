using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour
{
	public float speed = 5f;
	private Rigidbody2D body2d;
	// Use this for initialization
	void Start ()
	{
		body2d = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		var val = Input.GetAxis ("Horizontal");
		body2d.velocity = new Vector2 (speed * val, body2d.velocity.y);
	
	}
}
