using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreSetupScript : MonoBehaviour
{
	public int Players;
	public Text PlayerDisplay;

	private void Update()
	{
		PlayerDisplay.text = Players.ToString();
	}

	public void AddPlayer()
	{
		Players++;
	}

	public void RemovePlayer()
	{
		if (Players > 0)
		{
			Players--;
		}
	}
}
