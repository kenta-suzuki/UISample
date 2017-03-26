using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class BattleUI : MonoBehaviour {

	[SerializeField]
	Button AttackButton;
	[SerializeField]
	List<CharacterUI> CharacterUIs;
	[SerializeField]
	List<EnemyUI> EnemyUIs;


	public void OnAttackButtonClick()
	{
		var count = CharacterUIs.Count + EnemyUIs.Count;

		var index = Random.Range(0, count - 1);
		var damage = Random.Range(10, 500);

		if (index < CharacterUIs.Count)
		{
			CharacterUIs[index].ReciveDamage(damage);
		}
		else
		{
			EnemyUIs[index].ReciveDamage(damage);
		}
	}
}
