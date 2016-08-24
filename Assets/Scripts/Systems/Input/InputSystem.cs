using UnityEngine;
using System.Collections;

public class InputSystem : MonoBehaviour {

	public PlayerComponent[] players;

	void Update () {
		
		foreach (PlayerComponent player in players) {
			if (Input.GetKey (player.left)) {
				player.velocity += +player.acceleration * Time.deltaTime;
			} else if (Input.GetKey (player.right)) {
				player.velocity += -player.acceleration * Time.deltaTime;
			} else {
				if (-0.1f <= player.velocity && player.velocity <= 0.1f) {
					player.velocity = 0;
				} else {
					player.velocity += -Mathf.Sign (player.velocity) * player.acceleration * Time.deltaTime;	
				}
			}

			if (Mathf.Abs(player.velocity) > player.maxVelocity) {
				player.velocity = Mathf.Sign (player.velocity) * player.maxVelocity;
			}
		}

	}
}
