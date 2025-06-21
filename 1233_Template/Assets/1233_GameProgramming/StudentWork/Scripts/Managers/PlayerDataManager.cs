using UnityEngine;

public class PlayerDataManager : MonoBehaviour
{
	[SerializeField] private PlayerHUD Hud;
	[SerializeField] private int MaxHealth;
	[SerializeField] private int BaddieValue;
	
	private int _currentHealth;
	private int _playerScore;

	private void Start()
	{
		Hud.OnScoreUpdate(0);
		_currentHealth = MaxHealth;
		Hud.OnHealthUpdated(_currentHealth, MaxHealth);
	}

	private void AddScore(int score)
	{
		_playerScore += score;
		Hud.OnScoreUpdate(_playerScore);
	}

	public void OnBaddieKilled()
	{
		AddScore(BaddieValue);
	}
}

