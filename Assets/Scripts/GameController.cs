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
				restartText.text = "按R發動人生重來技能";
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
		scoreText.text = "母愛指數: " + score;
	}
	public void GameOver () {
		gameOverText.text = "FuRRRRRRRRRRRRRRRkkk!!!!!!!!!!\n來揍你喔快點重來快點重來呵呵重來RRRR!!!\n開始人生心人生開始吧!重來吧GG!按R重\n新開始人生!重來吧GG!你這個廢yo新來的人生阿!!!哈哈!!\n廢物~花惹法不不不不不!!!!~QQ!WTF!花惹法根說好的不一樣阿!!!!!!\n~QQ殺洨哇哈哈哈營營養不良!!!這啥洨東西啦甲慶記啦!WTF!你這個廢物~不阿\n阿阿阿阿阿阿你好棒你好棒你好棒你\n好棒你他馬的好棒你他馬的好棒你好\n棒快點重來快點重來快點重來你好棒\n你他馬的好棒你好棒你他馬的好棒你\n他馬的好棒阿阿你他馬的好棒你他呵\n呵馬的好棒你他馬的好棒你他呵呵馬\n的好棒快點阿阿重來快點重來快點重\n來快不就點阿阿重不就來你他馬的好\n呵呵棒你他馬的好棒你好棒你好呵呵\n棒你好棒呵呵你好棒好棒棒好棒棒阿\n阿好棒棒好棒棒好呵呵棒棒好棒棒好\n棒阿阿阿阿棒好不就棒棒好棒棒好棒\n棒快點重來呵呵快點重來呵呵快點重\n來揍你喔快點重來快點重來呵呵重來\n吧GG!按R重新開始人生!重來吧\nGG!你這個廢物~花惹法~QQ!\nWTF!花惹法~QQ!WTF!你\n這個廢物~不阿阿阿阿阿阿阿你好棒\n你好棒你好棒你好棒你他馬的好棒你\n他馬的好棒你好棒快點重來快點重來\n快點重來你好棒你他馬的好棒你好棒\n你他馬的好棒你他馬的好棒阿阿你他\n馬的好棒你他呵呵馬的好棒你他馬的\n好棒你他呵呵馬的好棒快點阿阿重來\n快點重來快點重來快不就點阿阿重不\n就來你他馬的好呵呵棒你他馬的好棒\n你好棒你好呵呵棒你好棒呵呵你好棒\n好棒棒好棒棒阿阿好棒棒好棒棒好呵\n呵棒棒好棒棒好棒阿阿阿阿棒好不就\n棒棒好棒棒好棒棒快點重來呵呵快點\n重來呵呵快點重來揍你喔快點重來快\n點重來呵呵RRRRRRRRRRR\nRRRRRRRRR!!!重來吧G\nG!按R重新開始人生!重來吧GG\n!你這個廢物~花惹法~QQ!WT\nF!花惹法~QQ!WTF!你這個\n廢物~不阿阿阿阿阿阿阿你好棒你好\n棒你好棒你好棒你他馬的好棒你他馬\n的好棒你好棒快點重來快點重來快點\n重來你好棒你他馬的好棒你好棒你他\n馬的好棒你他馬的好棒阿阿你他馬的\n好棒你他呵呵馬的好棒你他馬的好棒\n你他呵呵馬的好棒快點阿阿重來快點\n重來快點重來快不就點阿阿重不就來\n你他馬的好呵呵棒你他馬的好棒你好\n棒你好呵呵棒你好棒呵呵你好棒好棒\n棒好棒棒阿阿好棒棒好棒棒好呵呵棒\n棒好棒棒好棒阿阿阿阿棒好不就棒棒\n好棒棒好棒棒快點重來呵呵快點重來\n呵呵快點重來揍你喔快點重來快點重\n來呵呵重來吧GG!按R重新開始人\n生!重來吧GG!你這個廢物~花惹\n法~QQ!WTF!花惹法~QQ!\nWTF!你這個廢物~不阿阿阿阿阿\n阿阿你好棒你好棒你好棒你好棒你他\n馬的好棒你他馬的好棒你好棒快點重\n來快點重來快點重來你好棒你他馬的\n好棒你好棒你他馬的好棒你他馬的好\n棒阿阿你他馬的好棒你他呵呵馬的好\n棒你他馬的好棒你他呵呵馬的好棒快\n點阿阿重來快點重來快點重來快不就\n點阿阿重不就來你他馬的好呵呵棒你\n他馬的好棒你好棒你好呵呵棒你好棒\n呵呵你好棒好棒棒好棒棒阿阿好棒棒\n好棒棒好呵呵棒棒好棒棒好棒阿阿阿\n阿棒好不就棒棒好棒棒好棒棒快點重\n來呵呵快點重來呵呵快點重來揍你喔\n快點重來快點重來呵呵";
		gameOver = true;
	}
}