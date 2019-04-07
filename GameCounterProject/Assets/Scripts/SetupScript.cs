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

	public GameObject Scorecard;
	public GameObject[] OtherUI = new GameObject[2];

	[Space(20)]
	public GameObject PlayerPrefab;

	private void Awake()
	{
		DontDestroyOnLoad(this);
	}


	public void StartGame()
	{
		GameTitle = GameTitleInput.text;

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

		foreach (GameObject Go in OtherUI)
		{
			Go.SetActive(false);
		}

		Scorecard.SetActive(true);
	}
}
