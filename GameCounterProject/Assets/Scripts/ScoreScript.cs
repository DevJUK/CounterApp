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
	public Text[] PositionsUI;

	public int[] RoundScores;
	public string[] ScoreNames;
	public Dictionary<int, PlayerInfo> SavedRounds;

	public int RoundsPlayed;
	public int ActivePlayers;
	public static int MaxPlayers = 10;

	private List<PlayerInfo> OrderList;

	private bool NamesSet;


	private void Start()
	{
		SavedRounds = new Dictionary<int, PlayerInfo>();
		Players = new PlayerInfo[10];
	}

	public void ScoreUpdate()
	{
		for (int i = 0; i < ActivePlayers; i++)
		{
			//Sets up player names if it hasen't been done yet
			if (!NamesSet)
			{
				Players[i].name = GetComponent<SetupScript>().PlayerNames[i].text;
			}

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

		if (!NamesSet)
		{
			NamesSet = true;
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

		// sort and set positions
		Sort(OrderList);

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
			//Debug.Log("Test " + Input[i].score + ((float)(i+1) / 100));
		}

		Result.Sort();
		Result.Reverse();

		for (int i = 0; i < ActivePlayers; i++)
		{
			//Debug.Log("Sort: " + Result[i]);
		}


		for (int i = 0; i < Input.Count; i++)
		{
			float PlayerNumber = Input.IndexOf(Input[i]) + 1;
			PlayerNumber = PlayerNumber / 100;

			for (int j = 0; j < Result.Count; j++)
			{
				if (Result[j].ToString().Substring(Result[j].ToString().Length - 2) == (PlayerNumber.ToString().Substring(PlayerNumber.ToString().Length - 2)))
				{
					var list = Input[i];
					list.position = j+1;
					Input[i] = list;

					Debug.Log("Player: " + Input[i].name + " Position: " + Input[i].position + " Score: " + Input[i].score);
				}

				Debug.Log("loop running");
				Debug.Log(PlayerNumber);
			}
		}

		Debug.Log("end");

		UpdatePosition(Input);
	}



	private void UpdatePosition(List<PlayerInfo> Input)
	{
		// sets the position values
		for (int i = 0; i < ActivePlayers; i++)
		{
			foreach (PositionUpdater up in FindObjectsOfType<PositionUpdater>())
			{
				if (up.transform.parent.Find("PlayerName").GetComponent<Text>().text == Input[i].name)
				{
					Debug.Log(up.transform.parent.Find("PlayerName").GetComponent<Text>().text + "|||" + Input[i].name);

					up.Position = Input[i].position;
				}
			}
		}


		//orders the players in positions
		foreach (PositionUpdater up in FindObjectsOfType<PositionUpdater>())
		{
			Debug.Log(up.transform.parent.GetSiblingIndex() + "Position: " + up.Position);

			up.transform.parent.SetSiblingIndex(up.Position - 1);
		}
	}
}
