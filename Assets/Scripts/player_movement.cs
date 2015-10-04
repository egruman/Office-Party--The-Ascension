using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

	Vector2 myVec=new Vector2(0,0);
	public float speed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity=new Vector2(0, 0);
		if(Input.GetKey(KeyCode.RightArrow))
		{
			GetComponent<Rigidbody2D>().velocity=new Vector2(speed, 0);
			this.transform.GetChild(0).transform.rotation = 
				Quaternion.AngleAxis(-90, Vector3.forward);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody2D>().velocity=new Vector2(-speed, 0);
			this.transform.GetChild(0).transform.rotation = 
				Quaternion.AngleAxis(90, Vector3.forward);
		}
		
		if(Input.GetKey(KeyCode.DownArrow))
		{
			GetComponent<Rigidbody2D>().velocity=new Vector2(0, -speed);
			this.transform.GetChild(0).transform.rotation = 
				Quaternion.AngleAxis(180, Vector3.forward);
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			GetComponent<Rigidbody2D>().velocity=new Vector2(0, speed);
			this.transform.GetChild(0).transform.rotation = 
				Quaternion.AngleAxis(0, Vector3.forward);
		}
	}

}
