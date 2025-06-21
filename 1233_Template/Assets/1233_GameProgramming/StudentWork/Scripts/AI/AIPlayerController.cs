using System;
using UnityEngine;

public class AiPlayerController : MonoBehaviour
{
	[SerializeField] private int MaxHp;
	[SerializeField] private HealthBarDisplay HealthBar;
	[SerializeField] private int DamageLayer = 11;

	public Action<AiPlayerController> OnDeath;
	private float _currentHp;
	
    // Start is called before the first frame update
    private void Start()
	{
		_currentHp = MaxHp;
	}
	

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.layer == DamageLayer)
		{
			_currentHp --;
			OnDamageTaken();
		}
	}

	private void OnDamageTaken()
	{
		float currentHpPercent = _currentHp / MaxHp;
		HealthBar.UpdateHp(currentHpPercent);
		if (_currentHp <= 0)
		{
			OnDeath?.Invoke(this);
			Destroy(gameObject);
		}
	}
}
