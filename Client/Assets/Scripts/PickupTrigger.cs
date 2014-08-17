using UnityEngine;
using System.Collections;

public class PickupTrigger : MonoBehaviour {

	public string playerTag = "Player";
	public string energyTag = "EnergyOrb";

	void OnTriggerEnter2D(Collider2D other)
	{
		if ( other.gameObject.tag == energyTag )
		{
			//Debug.Log("Energy!!!!");
			Destroy (other.gameObject);
		}
		//Debug.Log ("Hit" + other.gameObject.tag );
	}
}
