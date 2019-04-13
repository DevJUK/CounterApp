using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionUpdater : MonoBehaviour
{
	public GameObject Players;
	public SetupScript Setup;
	public int Position;
	public Text ThisText;

	private void Start()
	{
		ThisText = GetComponent<Text>();
		Setup = FindObjectOfType<SetupScript>();
		Players = GameObject.Find("ActivePlayers");
	}


	private void Update()
	{
		switch (Position)
		{
			case 0:
				ThisText.color = Setup.Default;
				ThisText.text = "N/A";
				break;
			case 1:
				ThisText.color = Setup.Gold;
				ThisText.text = "1st";
				break;
			case 2:
				ThisText.color = Setup.Silver;
				ThisText.text = "2nd";
				break;
			case 3:
				ThisText.color = Setup.Bronze;
				ThisText.text = "3rd";
				break;
			case 4:
				ThisText.color = Setup.Default;
				ThisText.text = "4th";
				break;
			case 5:
				ThisText.color = Setup.Default;
				ThisText.text = "5th";
				break;
			case 6:
				ThisText.color = Setup.Default;
				ThisText.text = "6th";
				break;
			case 7:
				ThisText.color = Setup.Default;
				ThisText.text = "7th";
				break;
			case 8:
				ThisText.color = Setup.Default;
				ThisText.text = "8th";
				break;
			case 9:
				ThisText.color = Setup.Default;
				ThisText.text = "9th";
				break;
			case 10:
				ThisText.color = Setup.Default;
				ThisText.text = "10th";
				break;
			default:
				Debug.LogError("Error (PositionsUpdater) - Switch Case Default");
				break;
		}
	}
}




/* Archive
 * 
 * 				if (Players.GetChild(0).Find("PlayerScore").GetComponent<Text>().text == transform.parent.Find("PlayerScore").GetComponent<Text>().text)
				{
					ThisText.color = Setup.Gold;
					ThisText.text = "1st";
				}
				else if (Players.GetChild(Players.GetSiblingIndex()+1).Find("PlayerScore").GetComponent<Text>().text == transform.parent.Find("PlayerScore").GetComponent<Text>().text)
				{
					ThisText.color = Setup.Bronze;
					ThisText.text = "3rd";
				}
				else
				{
					ThisText.color = Setup.Silver;
					ThisText.text = "2nd";
				}


	*/