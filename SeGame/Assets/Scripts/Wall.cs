﻿using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	private AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	//碰撞播放声音
	void OnCollisionEnter2D() {
		audio.Play ();
	}
}