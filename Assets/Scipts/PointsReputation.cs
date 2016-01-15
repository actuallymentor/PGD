using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointsReputation : MonoBehaviour {
	private VariableHandler _varHandler;
	private Text _reputationPoints;

	// Use this for initialization
	void Start () {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");
		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();

		// Load the text element
		_reputationPoints = GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {
		_reputationPoints.text = _varHandler._reputationPoints.ToString();
	
	}
}
