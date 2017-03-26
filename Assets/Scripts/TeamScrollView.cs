using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamScrollView : MonoBehaviour
{

	public Text SubmitText;
	public Team CurrentTeam;

	public void OnSubmitButtonClick()
	{
		SubmitText.text = CurrentTeam.TeamNameText.text;
	}
}
