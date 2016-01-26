using UnityEngine;
using System.Collections;

public class HomeHealth : MonoBehaviour {

	private VariableHandler _varHandler;
	private Vector3 originPosition;
	private Quaternion originRotation;
	public float shake_decay;
	public float shake_intensity;

	void Start (  ) {
		GameObject theGround = GameObject.Find("Ground");
		// Load the vriable handle of the ground into a local variable
		_varHandler = theGround.GetComponent<VariableHandler>();
	} 



	 void OnTriggerEnter(Collider enemy) { // Activate shooting at contact
	 	if  ( enemy.tag == "enemy" ) {
	 		_varHandler._reputationPoints -= _varHandler._enemyStrength;
	 		_varHandler._hackerPoints += _varHandler._enemyStrength;
	 		Destroy(enemy.gameObject);
	 		Shake();
	 	} 
	 }


	 void Update (){
	 	if  ( _varHandler._reputationPoints < 0 ) {
	 		Destroy(gameObject);
	 	} 
	 	if (shake_intensity > 0){
	 		transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
	 		transform.rotation = new Quaternion(
	 			originRotation.x + Random.Range (-shake_intensity,shake_intensity) * .2f,
	 			originRotation.y + Random.Range (-shake_intensity,shake_intensity) * .2f,
	 			originRotation.z + Random.Range (-shake_intensity,shake_intensity) * .2f,
	 			originRotation.w + Random.Range (-shake_intensity,shake_intensity) * .2f);
	 		shake_intensity -= shake_decay;
	 	}
	 }

	 public void Shake(){
	 	originPosition = transform.position;
	 	originRotation = transform.rotation;
	 	shake_intensity = .09f;
	 	shake_decay = 0.005f;
	 }
	}
