using UnityEngine;
using System.Collections;

public class SpawnblockSpawn : MonoBehaviour {

	private VariableHandler _varHandler;
	private GameObject[] _enemyPrefab;
	public GameObject _enemyHacker;

	// Use this for initialization
	void Start () {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");
		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();
	
		// Agent prefab types
		_enemyPrefab = new GameObject[1];
		_enemyPrefab[0] = _enemyHacker;

		Spawn( 0 );
	}
	
	void Spawn ( int _enemyType ) {
		GameObject _hackerInstance = Instantiate(_enemyPrefab[_enemyType]);
		_hackerInstance.transform.position = transform.position + Vector3.up;
	}
}