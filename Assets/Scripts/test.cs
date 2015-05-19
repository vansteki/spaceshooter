using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	public float fSpeed, fHeight, fLength;
	public int iNumberOfBullets;
	public string sName;
	
	void Update(){
		fSpeed += Time.deltaTime;
//		Debug.Log(string.Format("Speed:{0}, Height:{1}, Length:{2}, Number of Bullets: {3}, Name: {4}",fSpeed,fHeight,fLength,iNumberOfBullets,sName));
	} 
}
