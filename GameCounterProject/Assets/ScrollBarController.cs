using UnityEngine;
using UnityEngine.UI;

public class ScrollBarController : MonoBehaviour
{

	private void Start()
	{
		// if there are less than 6 players in the game, the game will not have a scroll view and therefore disable the scroll rect.
		if (GameObject.FindGameObjectWithTag("GameController").GetComponent<SetupScript>().Count < 5)
		{
			transform.parent.GetComponent<ScrollRect>().enabled = false;		// disables the scroll rect component
			gameObject.SetActive(false);										// disables the scrollbar gameobject
		}
		// if there are 6 or more players, setup the scroll bar to work with the scroll rect via code.
		else
		{
			transform.parent.GetComponent<ScrollRect>().verticalScrollbar = GetComponent<Scrollbar>();
			transform.parent.GetComponent<ScrollRect>().verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHide;
		}
	}

}
