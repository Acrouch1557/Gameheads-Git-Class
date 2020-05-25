using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager instance;
	public TMPro.TMP_Text text; 
	int score;

    void Start ()
    {
        if(instance == null)
	{
		instance = this; 
	}
    }
	public void ChangeScore(int coinValue)
	{
		score += coinValue;
		text.text = "X"+score.ToString();
	}
}
