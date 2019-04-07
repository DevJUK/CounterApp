using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

	public GameObject MenuUI;
	public GameObject SetupUI;

	public void SwitchUI()
	{
		if (MenuUI.activeInHierarchy)
		{
			MenuUI.SetActive(false);
			SetupUI.SetActive(true);
		}
		else
		{
			MenuUI.SetActive(true);
			SetupUI.SetActive(false);
		}
	}
}
