using System.Collections.Generic;
using UnityEngine;

// Manages character-related logic like spawning and initialization.
public class CharacterManager : MonoBehaviour
{
	[SerializeField] private PlayerDataManager characterPrefab;

	[SerializeField] private AiPlayerController npcPrefab;

	[SerializeField] private int StartingNpcCount;

	private readonly List<AiPlayerController> _npcInstances = new();

	private PlayerDataManager _playerInstance;

	public void SpawnCharacters()
	{
		var spawnPosition = Vector3.zero;
		_playerInstance = Instantiate(characterPrefab, spawnPosition, Quaternion.identity, transform);

		for (var i = 0; i < StartingNpcCount; i++)
		{
			var npcPosition = Vector3.zero;
			var npc = Instantiate(npcPrefab, spawnPosition, Quaternion.identity, transform);
			npc.OnDeath = OnBaddieKilled;
			_npcInstances.Add(npc);
		}
	}

	public void OnBaddieKilled(AiPlayerController baddie)
	{
		_npcInstances.Remove(baddie);
		_playerInstance.OnBaddieKilled();
	}
}
