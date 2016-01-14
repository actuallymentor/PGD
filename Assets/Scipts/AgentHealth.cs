using UnityEngine;
using System.Collections;

public class AgentHealth : MonoBehaviour {

	// init variables
	private VariableHandler _varHandler;
	public int _instanceAgentType;
	public int _instanceHealth;
	private RaycastHit _agentSight;
	private bool _takingDamage;

	// Use this for initialization
	void Start () {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");
		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();
		// Set agent type
		_instanceAgentType = _varHandler._agentType;

		// Set the instance health
		_instanceHealth = _varHandler._agentHealth[_instanceAgentType];

		// initially not taking damage
		_takingDamage = false;

	}
	
	// Update is called once per frame
	void Update () {
		// Die if health is below zero
		if ( _instanceHealth < 0 ) {
			Destroy(gameObject);
		}

		// Set say position and direction
		var _agentEyes = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
		// Check if enemy is in sight
		if ( Physics.Raycast(_agentEyes, out _agentSight, 2.0f) ) {

			// Shoot only if the object in sight is an enemy
			if ( _agentSight.collider.tag == "enemy" && !_takingDamage) {
				InvokeRepeating("TakeDamage", 0f, 1f);
				_takingDamage = true;
			}

		} else {
			// If there is nothing in sight, cancel the shooting
			if ( _takingDamage ) {
				CancelInvoke("TakeDamage");
				_takingDamage = false;
			}
		}
	}

	void TakeDamage () {
		_instanceHealth -= _varHandler._enemyStrength;
	}


}
