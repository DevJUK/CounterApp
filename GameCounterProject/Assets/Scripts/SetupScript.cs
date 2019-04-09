using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetupScript : MonoBehaviour
{

	public Color32 Gold = new Color32(255, 215, 0, 255);
	public Color32 Silver = new Color32(192, 192, 192, 255);
	public Color32 Bronze = new Color32(139, 69, 19, 255);
	public Color32 Default = new Color32(127, 255, 212, 255);

	public string GameTitle;
	public Text GameTitleInput;

	public Text[] PlayerNameInputs = new Text[10];
	public Text[] PlayerNames = new Text[10];

	[Space(20)]
	public GameObject PlayerPrefab;

	private int Count;

	private void Awake()
	{
		DontDestroyOnLoad(this);
	}


	public void StartGame()
	{
		GameTitleInput.text = GameTitle;

		PlayerNames[0].text = PlayerNameInputs[0].text;
		PlayerNames[1].text = PlayerNameInputs[1].text;
		PlayerNames[2].text = PlayerNameInputs[2].text;
		PlayerNames[3].text = PlayerNameInputs[3].text;
		PlayerNames[4].text = PlayerNameInputs[4].text;
		PlayerNames[5].text = PlayerNameInputs[5].text;
		PlayerNames[6].text = PlayerNameInputs[6].text;
		PlayerNames[7].text = PlayerNameInputs[7].text;
		PlayerNames[8].text = PlayerNameInputs[8].text;
		PlayerNames[9].text = PlayerNameInputs[9].text;



		GetComponent<MenuController>().MenuUI.SetActive(false);
		GetComponent<MenuController>().SetupUI.SetActive(false);
		GetComponent<MenuController>().CardUI.SetActive(true);
		GetComponent<ScoreScript>().ActivePlayers = CountPlayers();
	}


	public int CountPlayers()
	{
		for (int i = 0; i < PlayerNames.Length; i++)
		{
			Debug.Log(PlayerNameInputs[i].text);

			if (PlayerNameInputs[i].text != "")
			{
				Count++;
			}
		}

		return Count;
	}
}
