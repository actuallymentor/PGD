using UnityEngine;
using System.Collections;

public class AgentFirewall : MonoBehaviour {
	public GameObject _fireWall;
	private VariableHandler _varHandler;

	// Use this for initialization
	void Start () {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");
		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();
	}
	
	// Build firewall upon click
	void OnMouseUpAsButton() {
		// Check if KP are sufficient to build the current agent type
		if (_varHandler._reputationPoints >= _varHandler._firewallCost){

			// Create an instance of the current agent type
			GameObject _agentInstance = Instantiate(_fireWall);

			// Put the new instance on top of the buildplace
			_agentInstance.transform.position = transform.position + Vector3.up - new Vector3(0,1,-0.5f);

			// Link it to parent
			_agentInstance.transform.parent = gameObject.transform;

			// Remove KP used to build the agent
			_varHandler._reputationPoints -= _varHandler._firewallCost;

			// Change tower health
			gameObject.GetComponent<AgentHealth>()._instanceHealth += _varHandler._firewallPower;
		}
	}
}
