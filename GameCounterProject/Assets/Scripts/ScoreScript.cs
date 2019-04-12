using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public struct PlayerInfo
{
	public string name;
	public int position;
	public int score;
}


public class ScoreScript : MonoBehaviour
{
	public PlayerInfo[] Players;

	public Text[] ScoresInputs;
	public Text[] PlayerScores;

	public int[] RoundScores;
	public string[] ScoreNames;
	public Dictionary<int, PlayerInfo> SavedRounds;

	public int RoundsPlayed;
	public int ActivePlayers;
	public static int MaxPlayers = 10;

	private List<PlayerInfo> OrderList;


	private void Start()
	{
		SavedRounds = new Dictionary<int, PlayerInfo>();
		Players = new PlayerInfo[10];

		for (int i = 0; i < ActivePlayers; i++)
		{
			Players[i].name = GetComponent<SetupScript>().PlayerNames[i].ToString();
		}

	}

	public void ScoreUpdate()
	{
		for (int i = 0; i < ActivePlayers; i++)
		{
			//if (RoundsPlayed == 0)
			//{
			//	Scores.Add(i, (int)GetFloat(ScoresInputs[i].text));
			//}
			//else
			//{
			//	Scores[i] = (int)(GetFloat(PlayerScores[i].text) + GetFloat(ScoresInputs[i].text));
			//}

			//PlayerScores[i].text = Scores[i].ToString();

			//ScoresInputs[i].GetComponentInParent<InputField>().Select();
			//ScoresInputs[i].GetComponentInParent<InputField>().text = null;


			// Updates the score by adding the int value from the current score to the inputted score int value
			Players[i].score = (int)(GetFloat(PlayerScores[i].text) + GetFloat(ScoresInputs[i].text));
			PlayerScores[i].text = ((int)(GetFloat(PlayerScores[i].text) + GetFloat(ScoresInputs[i].text))).ToString();

			// adds the player score to the undo dictionary 
			if (RoundsPlayed > 0)
			{
				SavedRounds.Add(i + (RoundsPlayed * ActivePlayers), Players[i]);
			}
			else
			{
				SavedRounds.Add(i, Players[i]);
 			}
		}

		OrderList = new List<PlayerInfo>();

		// Find position of each player in round and update their position value
		for (int i = 0; i < ActivePlayers; i++)
		{
			if (RoundsPlayed > 0)
			{
				OrderList.Add(SavedRounds[i + (RoundsPlayed * ActivePlayers)]);
				Debug.Log(SavedRounds[i + (RoundsPlayed*ActivePlayers)]);
			}
			else
			{
				OrderList.Add(SavedRounds[i]);
				Debug.Log(SavedRounds[i]);
			}
		}

		Sort(OrderList);

		for (int i = 0; i < ActivePlayers; i++)
		{
			Debug.Log(OrderList[i].name);
		}



		//Update number of rounds playerd
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

	

	private void Sort(List<PlayerInfo> Input)
	{
		List<float> Result = new List<float>();

		for (int i = 0; i < ActivePlayers; i++)
		{
			Result.Add(Input[i].score + ((float)(i+1) / 100));
			Debug.Log("Test " + Input[i].score + ((float)(i+1) / 100));
		}
	}
}
