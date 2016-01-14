using UnityEngine;
using System.Collections;

public class EnemyWalk : MonoBehaviour {

	// Init variables
	private VariableHandler _varHandler;
	public int _enemySpeed;

	// Use this for initialization
	void Start () {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");
		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();
		// load enemy speed
		_enemySpeed = _varHandler._enemySpeed;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.back*_enemySpeed*Time.deltaTime);
	}

	void OnTriggerEnter ( Collider _otherObject ) {
		if ( _otherObject.tag == "agent") {
			_enemySpeed = 0;
		}
	} 

}
