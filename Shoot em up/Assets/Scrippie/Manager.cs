using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public Text score;
    private int saveScore = 0;

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void EnemyDead()
    {
        saveScore ++;
        score.text = "Score = " + saveScore;
    }
}
