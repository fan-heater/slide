using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public Camera mainCamera;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mainCamera.transform.position = player.transform.position - new Vector3(-5, -3, 0);
		mainCamera.transform.LookAt(player.transform);
	}
}
