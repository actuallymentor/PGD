using UnityEngine;

public class VariableHandler : MonoBehaviour {

	// Initialise variables
	public int[] _agentCost;
	public int _killerPoints;
	public int _hackerPoints;
	public int _agentType;

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
	}
}
