using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointsHacker : MonoBehaviour {
	private VariableHandler _varHandler;
	private Text _hackerPoints;

	// Use this for initialization
	void Start () {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");
		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();

		// Load the text element
		_hackerPoints = GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {
		_hackerPoints.text = _varHandler._hackerPoints.ToString();
	
	}
}
