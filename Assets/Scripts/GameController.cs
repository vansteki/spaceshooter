using UnityEngine;
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

	void Start () {
		StartCoroutine(SpawnWaves());
	}

	IEnumerator SpawnWaves () {
		yield return new WaitForSeconds(startWait);
		for (int i = 0; i < hazardCount; i++) {
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (hazard, spawnPosition, spawnRotation);
			yield return new WaitForSeconds(spawnWait);
		}
		//Instantiate (hazard, spawnPosition, transform.rotation);
//		Debug.Log (transform.rotation);
//		Debug.Log (spawnRotation);
	}
}