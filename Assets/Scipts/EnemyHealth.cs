using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int _instanceHealth;
	private VariableHandler _varHandler;

	// Use this for initialization
	void Start () {

		// Find the ground
		GameObject theGround = GameObject.Find("Ground");

		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();

		// Set instance health
		_instanceHealth = _varHandler._enemyHealth;
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( _instanceHealth < 0 ) {
			Destroy ( gameObject ); 
		}
	
	}
}
