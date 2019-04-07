using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{

	public int?[][] RoundScores;

	public bool Round;
	public int RoundsPlayed;
	public static int MaxPlayers = 8;

    void Update()
    {
        if ((Round) && (RoundsPlayed == 0))
		{
			for (int i = 0; i < MaxPlayers; i++)
			{

			}

			Round = false;


		}
    }
}
