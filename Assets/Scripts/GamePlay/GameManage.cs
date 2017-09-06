using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour {
	public GameObject remain;
	public GameObject gameover;
	public static int rem;
	public GameObject ball;
	public GameObject linex;
	public GameObject liney;
	public GameObject linez;
	void Start () {
		rem = 1;
		remain.GetComponent<Text>().text = "●";
		gameover.GetComponent<Text>().enabled = false;
		//Instantiate(ball);
		// Instantiate(linex);
		// Instantiate(liney);
		// Instantiate(linez);
	}
	void Update () {
		//ゲームオーバー
		if ( rem == -1 ) {
			gameover.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
	}
}