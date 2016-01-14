using UnityEngine;
using System.Collections;

public class AgentShoot : MonoBehaviour {
	// Instantiate variables
	private bool _shooting;
	private RaycastHit _agentSight;

	private VariableHandler _varHandler;
	public GameObject _projectilePrefab;
	public int _instanceAgentType;

	void Start() {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");
		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();

		// Start tower as not shooting
		_shooting = false;

		// Set agent type
		_instanceAgentType = _varHandler._agentType;

	}

	void Update() {
		// Set say position and direction
		var _agentEyes = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
		// Check if enemy is in sight
		if (Physics.Raycast(_agentEyes, out _agentSight)) {

			// Shoot only if the object in sight is an enemy
			if ( _agentSight.collider.tag == "enemy" && !_shooting) {
				InvokeRepeating("Shoot", 0f, 1f);
				_shooting = true;
			}

		} else {
			// If there is nothing in sight, cancel the shooting
			if ( _shooting ) {
				CancelInvoke("Shoot");
				_shooting = false;
			}
		}
	}

	// Shoot a projectile
	void Shoot() {
		GameObject _projectile = Instantiate(_projectilePrefab);
		_projectile.transform.position = transform.position + new Vector3(0,0,0);
	}
}
