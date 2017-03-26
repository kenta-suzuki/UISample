using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideInOut : MonoBehaviour {
	
	public Animator SlideInOutAnimator;
	bool IsOpen = true;
	bool canClick = true;

	public void OnSlideButtonClick()
	{
		if (!canClick) return;
		SlideInOutAnimator.SetBool ("IsSlideIn", IsOpen);
		canClick = false;
	}

	public void FinishAnimation()
	{
		IsOpen = !IsOpen;
		canClick = true;
	}
}
