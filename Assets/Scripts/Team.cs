using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Team : MonoBehaviour
{
	public TeamScrollView TeamScrollView;
	public Image CheckImage;
	public Text TeamNameText;

	public void OnTeamSelectButtonClick()
	{
		if (TeamScrollView.CurrentTeam == null) 
		{
			TeamScrollView.CurrentTeam = this;
			CheckImage.gameObject.SetActive (true);
			return;
		}
		
		if (TeamScrollView.CurrentTeam.TeamNameText != TeamNameText)
		{
			TeamScrollView.CurrentTeam.CheckImage.gameObject.SetActive (false);
			CheckImage.gameObject.SetActive (true);
			TeamScrollView.CurrentTeam = this;
			return;
		}

		CheckImage.gameObject.SetActive (false);
		TeamScrollView.CurrentTeam = null;
	}
}
