using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LowScoringGamePlayer : MonoBehaviour
{

	internal int PlayerScore;
	public Text Score;

	private void Start()
	{
		Score = GetComponentsInChildren<Text>()[2];
	}

	private void Update()
	{
		Score.text = PlayerScore.ToString();
	}

	public void AddToScore()
	{
		PlayerScore++;
	}

	public void SubtractFromScore()
	{
		PlayerScore--;
	}
}
