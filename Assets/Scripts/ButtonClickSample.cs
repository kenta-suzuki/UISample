using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickSample : MonoBehaviour
{
	public Text ButtonText;

	public void OnButtonClick()
	{
		ButtonText.text = "クリックされました";
	}
}
