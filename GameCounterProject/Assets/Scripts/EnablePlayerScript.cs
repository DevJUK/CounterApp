using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnablePlayerScript : MonoBehaviour
{

	public Text PlayerName;

	private void Update()
	{
		if (string.IsNullOrEmpty(PlayerName.text))
		{
			gameObject.SetActive(false);
		}
	}

}
