using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

	public List<List <int>> RoundScores;

	public Dictionary<int, int> Scores;

	public Text[] ScoresInputs;
	public Text[] PlayerScores;
	public Text[] PlayerDiff;

	public int RoundsPlayed;
	public int ActivePlayers;
	public static int MaxPlayers = 10;

	private List<int> OrderList;


	private void Start()
	{
		Scores = new Dictionary<int, int>();
	}

	public void ScoreUpdate()
	{
		for (int i = 0; i < ActivePlayers; i++)
		{
			if (RoundsPlayed == 0)
			{
				Scores.Add(i, (int)GetFloat(ScoresInputs[i].text));
			}
			else
			{
				Scores[i] = (int)(GetFloat(PlayerScores[i].text) + GetFloat(ScoresInputs[i].text));
			}

			PlayerScores[i].text = Scores[i].ToString();

			ScoresInputs[i].GetComponentInParent<InputField>().Select();
			ScoresInputs[i].GetComponentInParent<InputField>().text = null;
		}

		RoundsPlayed++;

	}

	public void ResetScores()
	{
		RoundsPlayed = 0;
	}

	public float GetFloat(string input)
	{
		float result;
		float.TryParse(input, out result);
		return result;
	}

	private void UpdateOrder()
	{
		int OrderCount;

		for (int i = 0; i < ActivePlayers; i++)
		{
			OrderList.Add(Scores[i]);
		}

		OrderList.Sort();

		foreach (int item in OrderList)
		{
			for (int i = 0; i < ActivePlayers; i++)
			{
				if (Scores[i] == OrderList[item])
				{

				}
			}
		}
	}
}
