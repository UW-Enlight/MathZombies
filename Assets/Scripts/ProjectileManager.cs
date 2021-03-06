﻿using UnityEngine;
using System.Collections;

public class ProjectileManager : MonoBehaviour {

	float timer;
	public float timeBetweenBullets;
	public GameObject projectile;
	public Transform spawn;
	private AudioSource shootSound;

	// Use this for initialization
	void Start () {
		timer = 0f;

		shootSound = GameObject.Find ("/LaserShoot").GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if((Input.GetButton ("Fire1") || Cardboard.SDK.Triggered) && timer >= timeBetweenBullets)
		{
			Shoot ();
		}
	}

	void Shoot(){
		shootSound.Play ();
		Instantiate (projectile, spawn.position, spawn.rotation);
		timer = 0f;
	}
}
