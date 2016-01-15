using UnityEngine;

public class BlockTowerSpawn : MonoBehaviour {

 	// Instantiate used variables
	private GameObject[] _agentPrefabs;
	private VariableHandler _varHandler;
	public GameObject _regularAgent;
	public GameObject _corporateAgent;

	void Start() {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");
		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();

		// Create an array of 2 to store the agent prefabs in
		_agentPrefabs = new GameObject[2];

		// Load the regular agent into the first array slot
		_agentPrefabs[0] = _regularAgent;

		// Load the corporate agent into the second array slot
		_agentPrefabs[1] = _corporateAgent;
	}

	// Build an agent upon mouse release
	void OnMouseUpAsButton() {
		// Check if KP are sufficient to build the current agent type
		if (_varHandler._hackerPoints >= _varHandler._agentCost[_varHandler._agentType]){

			// Create an instance of the current agent type
			GameObject _agentInstance = Instantiate(_agentPrefabs[_varHandler._agentType]);

			// Put the new instance on top of the buildplace
			_agentInstance.transform.position = transform.position + Vector3.up - new Vector3(0,0,0);

			// Remove KP used to build the agent
			_varHandler._hackerPoints -= _varHandler._agentCost[_varHandler._agentType];
		}
	}


}