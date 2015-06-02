﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//@try serialize here to group 2 public properties in the future?
	public GameObject hazard;
	public Vector3 spawnValues;
	public float hazardCount;
	//@public Vector3 test = new Vector3(1,2,3);
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public GUIText scoreText;
	public GUIText restartText;
	public GUIText gameOverText;

	private bool gameOver;
	private bool restart;
	private int score;

	void Start () {
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		score = 0;
		UpdateScore ();
		StartCoroutine(SpawnWaves());
	}

	void Update()
	{
		if (restart) 
		{
			if (Input.GetKeyDown(KeyCode.R)) 
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}

	IEnumerator SpawnWaves () {
		yield return new WaitForSeconds(startWait);
		while(true) {
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);

			if (gameOver) {
				restartText.text = "Press 'R' for Restart";
				restart = true;
				break;
			}
			//Instantiate (hazard, spawnPosition, transform.rotation);
	//		Debug.Log (transform.rotation);
	//		Debug.Log (spawnRotation);
		}
	}
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}
	public void GameOver () {
		gameOverText.text = "GAME OVER!";
		gameOver = true;
	}
}