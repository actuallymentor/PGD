using UnityEngine;

public class BlockHighlight : MonoBehaviour {

	private Color startcolor;
	void OnMouseEnter()
	{
		startcolor = GetComponent<Renderer>().material.color;
		GetComponent<Renderer>().material.color = Color.grey;
	}
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = startcolor;
	}
}
