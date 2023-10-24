using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Subscriber : MonoBehaviour{
	
	public Publisher publisher;
	
	public bool PrintsJump = false;
	
	void Start(){
		if(PrintsJump){
			publisher.OnJump += PrintJump;
		}
		if(!PrintsJump){
			publisher.OnWASD += PrintWASD;
		}
	}
	
	void PrintJump(object sender, EventArgs e){
		Debug.Log("You Pressed Space");
	}
	
	void PrintWASD(object sender, Publisher.WASDEventArgs e){
		Debug.Log("You Pressed a WASD: " + e.pressed);
	}
	
	/*
	// Start is called before the first frame update
	void Start(){
		publisher.OnSpacebarPressed += PrintSubscribeSpace;
		publisher.OnSpacePressedWithEventArgs += PrintSubscribeSpaceWithEventArgs;
	}
	
	void PrintSubscribeSpace(object sender, EventArgs e){
		Debug.Log("Subscriber: You Pressed Space");
	}
	
	void PrintSubscribeSpaceWithEventArgs(object sender, Publisher.OnSpacePressedEventArgs e){
		Debug.Log("Subscriber: You Pressed Space, also: " + e.TheBool + ", " + e.TheInt + ", " + e.TheFloat);
	}
	*/
	
}
