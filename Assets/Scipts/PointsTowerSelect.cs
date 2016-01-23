using UnityEngine;
using System.Collections;

public class PointsTowerSelect : MonoBehaviour {

	public int _selectGridOut = 0;
	public string[] _selectableStrings = new string[] {"Gov Agent", "Corp Agent", "Generator"};
	private VariableHandler _varHandler;

	void Start (  ) {
		// Find the ground
		GameObject theGround = GameObject.Find("Ground");
		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();
	} 

	void OnGUI (  ) {

		_selectGridOut = GUI.SelectionGrid(new Rect(300,320,200,100), _selectGridOut, _selectableStrings, 1);

		_varHandler._agentType = _selectGridOut;

	}

}