using UnityEngine;

public class BlockTowerSpawn : MonoBehaviour {

 // The Tower that should be built
	public GameObject[] _agentPrefabs;
	public VariableHandler _varHandler;
	public GameObject _regularAgent;
	public GameObject _corporateAgent;


	void Start() {
		GameObject theGround = GameObject.Find("Ground");
		_varHandler = theGround.GetComponent<VariableHandler>();
		_agentPrefabs = new GameObject[2];
		_agentPrefabs[0] = _regularAgent;
		_agentPrefabs[1] = _corporateAgent;
	}

	// Build an agent upon mouse release
	void OnMouseUpAsButton() {
		if (_varHandler._killerPoints >= _varHandler._agentCost[_varHandler._agentType]){
    	        // Build Tower above Buildplace
			GameObject _agentInstance = Instantiate(_agentPrefabs[_varHandler._agentType]);
			_agentInstance.transform.position = transform.position + Vector3.up - new Vector3(0,0,0);
			_varHandler._killerPoints -= _varHandler._agentCost[_varHandler._agentType];
		}
	}

}
