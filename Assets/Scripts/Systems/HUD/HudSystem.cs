using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HudSystem : MonoBehaviour 
{
    public PlayerComponent[] players;
    public RectTransform[] playerBars;

    void Update()
    {
        for (int i = 0; i < players.Length; i++)
        {
            playerBars[i].localScale = new Vector3(players[i].velocity * -1, 1, 1);
        }
    }
	
}
