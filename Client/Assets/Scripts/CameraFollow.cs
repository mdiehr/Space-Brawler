using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public string playerTag = "Player";

	private Transform player;		// Reference to the player's transform.
	
	void Awake() {
		// Setting up the reference.
		player = GameObject.FindGameObjectWithTag(playerTag).transform;
	}
	
	// Changed where the camera postion is updated in an attempt to fix the player sprite jitter
	void LateUpdate() {
		TrackPlayer();
	}
	
	void TrackPlayer() {
		Vector3 point = camera.WorldToViewportPoint(player.position);
		Vector3 delta = player.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
		Vector3 destination = transform.position + delta;
		transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
	}
}
