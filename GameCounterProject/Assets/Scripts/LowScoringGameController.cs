using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LowScoringGameController : MonoBehaviour
{
	public Canvas SetupCanvas;
	public Canvas LSGCanvas;
	public GameObject PlayerPrefab;
	public GameObject Viewport;


	public void SetPlayers(PreSetupScript Script)
	{
		if (Script.Players >= 2)
		{
			for (int i = 0; i < Script.Players; i++)
			{
				Instantiate(PlayerPrefab, Viewport.transform);
			}
		}
	}


	public void SetGroupHeight()
	{
		Viewport.GetComponent<RectTransform>().sizeDelta += new Vector2(0, Viewport.GetComponent<VerticalLayoutGroup>().preferredHeight);
		MoveToScoreboard();
	}


	private void MoveToScoreboard()
	{
		SetupCanvas.enabled = false;
		LSGCanvas.enabled = true;
	}
}
