using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour 
{
	public Animator SlideAnimator;

	public void OnSlideInButtonClick()
	{
		SlideAnimator.SetTrigger ("SlideIn");
	}

	public void OnSlideOutButtonClick()
	{
		SlideAnimator.SetTrigger ("SlideOut");
	}
}
