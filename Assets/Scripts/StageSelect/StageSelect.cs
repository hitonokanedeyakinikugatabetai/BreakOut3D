using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour {
	public GameObject fadeIn;
	public GameObject fadeOut;
	public static int stageNum;
	void Start () {
		Instantiate(fadeIn);
		stageNum = 1;
	}
}
