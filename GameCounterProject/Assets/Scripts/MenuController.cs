using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

	public GameObject MenuUI;
	public GameObject SetupUI;
	public GameObject CardUI;

	public void SwitchUI()
	{
		if (MenuUI.activeInHierarchy)
		{
			MenuUI.SetActive(false);
			SetupUI.SetActive(true);
			SetupUI.GetComponentInChildren<Scrollbar>().value = 1;
		}
		else
		{
			MenuUI.SetActive(true);
			SetupUI.SetActive(false);
		}
	}
}
