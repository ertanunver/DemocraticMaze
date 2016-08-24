using UnityEngine;
using System.Collections;

public class RotationSystem : MonoBehaviour {

	public Transform maze;
	public PlayerComponent[] players;

	void Update () {

		float velocity = 0;
		foreach (PlayerComponent player in players) {
			velocity += player.velocity;
		}

		maze.Rotate (new Vector3(0, 0, velocity));

	}

}
