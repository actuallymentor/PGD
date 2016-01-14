using UnityEngine;

public class VariableHandler : MonoBehaviour {

	// Initialise variables
	public int[] _agentCost;
	public int _killerPoints;
	public int _hackerPoints;
	public int _agentType;
	public int[] _agentHealth;
	public int _enemyStrength;

	void Start() {

		// //////////////////
		// Player variables
		// //////////////////
		_killerPoints = 1000;
		_hackerPoints = 1000;

		// /////////////////////////
		// Defensive agent control
		// ////////////////////////

		// Tower costs
		_agentCost = new int[2];
		_agentCost[0] = 5; // Costs for a regular agent
		_agentCost[1] = 10; // Costs for a corporate agent

		// Current tower type
		_agentType = 0;

		// Agent health control
		_agentHealth = new int[2];
		_agentHealth[0] = 100; // Costs for a regular agent
		_agentHealth[1] = 100; // Costs for a corporate agent


		// ////////////////////////
		// Offensive agent control
		// ////////////////////////
		_enemyStrength = 5;

	}
}
