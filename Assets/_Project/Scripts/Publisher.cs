using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Publisher : MonoBehaviour{
	
	public class WASDEventArgs : EventArgs{
		public char pressed;
	}
	
	public event EventHandler OnJump;
	public event EventHandler<WASDEventArgs> OnWASD;
	
	void Update(){
		
		if(Input.GetKeyDown("w")){
			OnWASD.Invoke(this, new WASDEventArgs{pressed = 'W'});
		}
		if(Input.GetKeyDown("a")){
			OnWASD.Invoke(this, new WASDEventArgs{pressed = 'A'});
		}
		if(Input.GetKeyDown("s")){
			OnWASD.Invoke(this, new WASDEventArgs{pressed = 'S'});
		}
		if(Input.GetKeyDown("d")){
			OnWASD.Invoke(this, new WASDEventArgs{pressed = 'D'});
		}
		if(Input.GetKeyDown("space")){
			OnJump.Invoke(this, EventArgs.Empty);
		}
		
	}
	
	/*
	public event EventHandler OnSpacebarPressed;

	// event args child class to create event arg objects
	public class OnSpacePressedEventArgs : EventArgs{
		public bool TheBool;
		public int TheInt;
		public float TheFloat;
	}

	// new event handler that uses custom event arg object defined above
	public event EventHandler<OnSpacePressedEventArgs> OnSpacePressedWithEventArgs;

	// Update is called once per frame
	void Update(){
		if(Input.GetKeyDown("space")){
			OnSpacebarPressed?.Invoke(this, EventArgs.Empty);
			OnSpacePressedWithEventArgs?.Invoke(this, new OnSpacePressedEventArgs{TheBool = true, TheInt = 123456, TheFloat = 123.456f});
		}
	}
	*/
	
}
