using UnityEngine;
using System.Collections;

public class PickupTrigger : MonoBehaviour {

	public string playerTag = "Player";
	public string energyTag = "EnergyOrb";

	// Event that triggers when the player contacts a collider marker as a trigger
	void OnTriggerEnter2D(Collider2D other)
	{
		// Only destroy object if it is tagged as energy orb
		if ( other.gameObject.tag == energyTag )
		{
			//Debug.Log("Energy!!!!");
			Destroy (other.gameObject);
		}
		//Debug.Log ("Hit" + other.gameObject.tag );
	}
}
