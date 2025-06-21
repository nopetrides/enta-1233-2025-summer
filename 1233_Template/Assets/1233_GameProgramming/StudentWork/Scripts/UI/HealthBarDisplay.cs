using UnityEngine;
using UnityEngine.UI;

public class HealthBarDisplay : MonoBehaviour
{
	[SerializeField] private Image HealthBarFill;

	/// <summary>
	/// Update the health bar
	/// </summary>
	/// <param name="hpPercent">Value from 0-1</param>
	public void UpdateHp(float hpPercent)
	{
		HealthBarFill.fillAmount = Mathf.Clamp(hpPercent, 0, 1);
	}
}
