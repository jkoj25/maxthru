using UnityEngine;
using System.Collections;

public class west_to_south : MonoBehaviour {
	
	private Rigidbody2D rb2d;
	private int counter=0;
	private float speed = 25.0f;
	public float constantx;
	public float variabley;
	public float rand1,rand2,rand3;
	
	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();	
		//start x = -6.6, y = -0.77
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float speed = 0.05f;
		if (transform.position.x <= -3.65f)
		{
			transform.right = new Vector3(speed,0,0.0f);
			transform.position = transform.position+new Vector3(speed,0,0.0f);
		}
		else if (transform.position.x <= -3.6f)
		{
			transform.right = new Vector3(0.001f,0,0.0f);
			transform.position = transform.position+new Vector3(0.001f,0,0.0f);
		}
		else if (transform.position.x <= -2.0f)
		{
			transform.right = new Vector3(speed,0,0.0f);
			transform.position = transform.position+new Vector3(speed,0,0.0f);
		}
		else if (transform.position.x >= -2.0f && transform.position.x <= -1.475f) 
		{
			float x = speed/1.41f;
			transform.right = new Vector3(x,-x,0.0f);
			transform.position = transform.position+new Vector3(x,-x,0.0f);
		}
		else if (transform.position.y >= -3.2f)
		{
			transform.right = new Vector3(0f,-speed,0.0f);
			transform.position = transform.position+new Vector3(0f,-speed,0.0f);
		}
		else
		{
			float donothing = 0;
		}
	}
}
