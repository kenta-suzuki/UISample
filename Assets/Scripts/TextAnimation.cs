using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{
	[SerializeField]
	string DisplayString;
	[SerializeField]
	Text text;
	[SerializeField]
	float WaitTime;

	void Start()
	{
		StartCoroutine(WaitForOneWord());
	}

	IEnumerator WaitForOneWord()
	{
		var str = "";
		var index = 0;
		while (DisplayString.Length > index)
		{
			str += DisplayString[index];
			text.text = str;
			index++;

			yield return new WaitForSeconds(WaitTime);
		}
	}
}
