using UnityEngine;

public class VariableHandler : MonoBehaviour {

	// Initialise variables

	// Agents 
	public int[] _agentCost;
	public int[] _agentHealth;
	public int _agentDamage;
	public int _agentType; // Includes generator

	// KPIs
	public int _reputationPoints;
	public int _hackerPoints;

	// Enemies
	public int _enemyStrength;
	public int _enemyHealth;
	public int _enemySpeed;
	public int _enemyValue;

	// Generators
	public int _generatorPower;

	void Start() {

		// //////////////////
		// Player variables
		// //////////////////
		_reputationPoints = 1000;
		_hackerPoints = 1000;

		// /////////////////////////
		// Defensive agent control
		// ////////////////////////

		// Tower costs
		_agentCost = new int[3];
		_agentCost[0] = 5; // Costs for a regular agent
		_agentCost[1] = 10; // Costs for a corporate agent
		_agentCost[2] = 5; // Generator tower

		// Current tower type
		_agentType = 0;

		// Agent health control
		_agentHealth = new int[3];
		_agentHealth[0] = 100; // Costs for a regular agent
		_agentHealth[1] = 100; // Costs for a corporate agent
		_agentHealth[2] = 100;

		// Agent offense control
		_agentDamage = 20;


		// ////////////////////////
		// Offensive agent control
		// ////////////////////////
		_enemyStrength = 5;
		_enemyHealth = 100;
		_enemySpeed = 1;
		_enemyValue = 5; // How much does killing an enemy gain in Killer Points

		// ////////////////////////
		// Generators
		// ////////////////////////
		_generatorPower = 5;
	}
}
