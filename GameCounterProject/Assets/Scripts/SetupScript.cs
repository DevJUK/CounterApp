using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetupScript : MonoBehaviour
{

	public string GameTitle;
	public Text GameTitleInput;

	public string[] PlayerNames;
	public Text Player1;
	public Text Player2;
	public Text Player3;
	public Text Player4;
	public Text Player5;
	public Text Player6;
	public Text Player7;
	public Text Player8;

	private void Awake()
	{
		DontDestroyOnLoad(this);
	}


	public void StartGame()
	{
		GameTitle = GameTitleInput.text;

		PlayerNames = new string[8];

		PlayerNames[0] = Player1.text;
		PlayerNames[1] = Player2.text;
		PlayerNames[2] = Player3.text;
		PlayerNames[3] = Player4.text;
		PlayerNames[4] = Player5.text;
		PlayerNames[5] = Player6.text;
		PlayerNames[6] = Player7.text;
		PlayerNames[7] = Player8.text;

		SceneManager.LoadSceneAsync(1);
	}
}
