using UnityEngine;
using System.Collections;

public class GeneratorGenerate : MonoBehaviour {

	private VariableHandler _varHandler;


	// Use this for initialization
	void Start () {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");

		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();

		// Invoke generation
		InvokeRepeating("GenerateMojo", 5f, 5f);

	}
	
	// Generate Hacker Points
	void GenerateMojo (  ) {
		// Add hacker points
		_varHandler._reputationPoints += _varHandler._generatorPower;
	}


}
