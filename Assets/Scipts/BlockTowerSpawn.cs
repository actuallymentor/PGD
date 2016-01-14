using UnityEngine;

public class BlockTowerSpawn : MonoBehaviour {

 // The Tower that should be built
	public GameObject _agentPrefab;
	public VariableHandler _varHandler;

	void Start() {
		GameObject theGround = GameObject.Find("Ground");
		_varHandler = theGround.GetComponent<VariableHandler>();
	}

	// Build an agent upon mouse release
	void OnMouseUpAsButton() {
		if (_varHandler._killerPoints >= _varHandler._agentCostRegular){
    	        // Build Tower above Buildplace
			GameObject _agentInstance = Instantiate(_agentPrefab);
			_agentInstance.transform.position = transform.position + Vector3.up - new Vector3(0,0,0);
			_varHandler._killerPoints -= _varHandler._agentCostRegular;
		}
	}

}
