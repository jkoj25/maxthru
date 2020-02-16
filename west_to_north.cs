using UnityEngine;
using System.Collections;

public class west_to_north : MonoBehaviour {
	
	private Rigidbody2D rb2d;
	private int counter=0;
	private float speed = 25.0f;
	public float pausex = -3.6f;
	public float pausespeed = 0.001f;
	public int waitcount = 500;
	
	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();	
		//start x = -6.6, y = 0.035
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (counter < waitcount)
			counter++;
		else
		{
			float speed = 0.05f;
			if (transform.position.x <= -3.65f)
			{
				transform.right = new Vector3(speed,0,0.0f);
				transform.position = transform.position+new Vector3(speed,0,0.0f);
			}
			else if (transform.position.x <= pausex)
			{
				transform.right = new Vector3(pausespeed,0,0.0f);
				transform.position = transform.position+new Vector3(0.001f,0,0.0f);
			}
			else if (transform.position.x <= -0.4f)
			{
				transform.right = new Vector3(speed,0,0.0f);
				transform.position = transform.position+new Vector3(speed,0,0.0f);
			}
			else if (transform.position.x >= -0.4f && transform.position.x <= 0.4f) 
			{
				float x = speed/1.41f;
				transform.right = new Vector3(x,x,0.0f);
				transform.position = transform.position+new Vector3(x,x,0.0f);
			}
			else// if (transform.position.y <= 3.2f)
			{
				transform.right = new Vector3(0f,speed,0.0f);
				transform.position = transform.position+new Vector3(0f,speed,0.0f);
			}
			/*else
			{
				float donothing = 0;
			}*/
		}
	}
}
