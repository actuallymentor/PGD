using UnityEngine;
using System.Collections;

public class AgentProjectile : MonoBehaviour {

	// Init variables
	private Vector3 _initialPosition;
	private int _projectileSpeed;
	private VariableHandler _varHandler;

	// Use this for initialization
	void Start () {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");

		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();

		// Save the initial position
		_initialPosition = transform.position;

		// Set projectile speed
		_projectileSpeed = 5;
	}
	
	// Update is called once per frame
	void Update () {

		// Propel the projectile
		transform.Translate(Vector3.forward*_projectileSpeed*Time.deltaTime);

		// Destroy projectile if it moved a bunch
		if ( Vector3.Distance(transform.position, _initialPosition) > 50) {
			Destroy(gameObject);
		}
	}

	// Hurt the enemy if we bump into it
	void OnTriggerEnter ( Collider _otherObject ) {
		if ( _otherObject.tag == "enemy" ) {
			_otherObject.GetComponent<EnemyHealth>()._instanceHealth -= _varHandler._agentDamage;
			Debug.Log("Enemy health: " + _otherObject.GetComponent<EnemyHealth>()._instanceHealth);
			Destroy ( gameObject ); 
		} 
	}

}
