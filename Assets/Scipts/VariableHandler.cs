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
		// Defensive tower control
		// ////////////////////////

		// Tower costs
		_agentCost = new int[2];
		_agentCost[0] = 5;
		_agentCost[1] = 10;

		// Current tower type
		_agentType = 0;
	}
}
