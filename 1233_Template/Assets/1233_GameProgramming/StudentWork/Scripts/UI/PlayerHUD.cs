using System;
using TMPro;
using UnityEngine;


public class PlayerHUD : MonoBehaviour
{
	[SerializeField] private TMP_Text HealthText;
	[SerializeField] private TMP_Text ScoreText;

	public void OnHealthUpdated(int health, int maxHealth)
	{
		HealthText.text = $"{health}/{maxHealth}";
	}

	public void OnScoreUpdate(int score)
	{
		ScoreText.text = $"{score} baddies killed";
	}
}
