using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour 
{
	public Animator DialogAnimator;

	public void OnDialogOpenButtonClick()
	{
		DialogAnimator.SetBool ("IsOpen", true);
	}

	public void OnDialogCloseButtonClick()
	{
		DialogAnimator.SetBool ("IsOpen", false);
	}
}
