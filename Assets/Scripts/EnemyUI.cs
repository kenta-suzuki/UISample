using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour {

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

	void Start()
	{
		currentHp = MaxHP;
	}

	public void ReciveDamage(int damage)
	{
		currentHp -= damage;
		StartDamageAnimation();
	}

	void StartDamageAnimation()
	{
		Animator.SetBool("IsHit", true);
	}
}
