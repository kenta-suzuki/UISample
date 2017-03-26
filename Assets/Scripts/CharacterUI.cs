using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour {

	[SerializeField]
	string CharacterName;
	[SerializeField]
	int MaxHP;
	int currentHp;
	[SerializeField]
	Image HPImage;
	[SerializeField]
	int MaxMP;
	[SerializeField]
	Animator Animator;

	public bool IsLiving { get { return currentHp > 0; } }
	float Amount { set { HPImage.fillAmount = value; } }

	void Start()
	{
		currentHp = MaxHP;
	}

	public void ReciveDamage(int damage)
	{
		StartCoroutine(DelHP(damage));
		StartDamageAnimation();
	}

	IEnumerator DelHP(int damage)
	{
		var delDamage = damage / 100;

		int index = 0;
		var tempHp = currentHp;
		while (index < 100)
		{
			currentHp -= delDamage;
			Amount = (float)currentHp / (float)MaxMP;
			index++;
			yield return null;
		}
		tempHp -= damage;
		currentHp = tempHp;
		Amount = (float)currentHp / (float)MaxMP;
	}

	void StartDamageAnimation()
	{
		Animator.SetBool("IsHit", true);
	}
}
