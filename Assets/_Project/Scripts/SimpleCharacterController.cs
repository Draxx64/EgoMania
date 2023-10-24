using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour{
	
	public Rigidbody rb;
	
	public float MoveForce = 0.1f;
	public float JumpForce = 5f;
	
	// Start is called before the first frame update
	void Start(){
		
	}
	
	// Update is called once per frame
	void Update(){
		
		// get movement direction
		Vector2 Direction = Vector2.zero;
		if(Input.GetKey("w")){
			Direction += Vector2.up;
		}
		if(Input.GetKey("a")){
			Direction += Vector2.left;
		}
		if(Input.GetKey("s")){
			Direction += Vector2.down;
		}
		if(Input.GetKey("d")){
			Direction += Vector2.right;
		}
		if(Input.GetKeyDown("space")){
			Jump();
		}
		
		if(Input.GetKeyDown("escape")){
			UnityEditor.EditorApplication.ExitPlaymode();
		}
		
		// change 2d to top down 3d and move
		rb.AddForce(new Vector3(Direction.x, 0, Direction.y).normalized * MoveForce, ForceMode.Impulse);
		
	}
	
	void Jump(){
		rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
	}
}
