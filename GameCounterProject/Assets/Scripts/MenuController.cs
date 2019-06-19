using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

	public Canvas MenuUI;
	public Canvas ModeSelUI;


	public void Move2ModeSel()
	{
		MenuUI.enabled = false;
		ModeSelUI.enabled = false;

	}
}
