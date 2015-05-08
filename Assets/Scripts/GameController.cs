using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//@try serialize here to group 2 public properties in the future?
	public GameObject hazard;
	public Vector3 spawnValues;
	//@public Vector3 test = new Vector3(1,2,3);

	void Start () {
		SpawnWaves();
	}

	void SpawnWaves () {
		Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (hazard, spawnPosition, spawnRotation);
		//Instantiate (hazard, spawnPosition, transform.rotation);
		Debug.Log (transform.rotation);
		Debug.Log (spawnRotation);
	}
}