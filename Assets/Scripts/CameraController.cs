using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float dumping = 1.5f;
    public Vector2 offset = new Vector2(2f, 1f);
    public bool isLeft;
    private Transform player;
    private int lastX;

    void Start()
    {
        // offset = new Vector2(Mathf.Abs(offset.x), offset.y);
        // FindPlayer(isLeft);
    }

    // public void isLeft(bool playerIsLeft)
    // {
        // player = GameObject.FindGameObjectWithTag("Player").transform;
        // lastX = Mathf.RoundToInt(player.position.x);
        //
        // if (playerIsLeft)
        // {
        //     transform.position = new Vector3(player.position.x);
        // }
        // else
        // {
        //     transform.position = new Vector3();
        // }
    // }
}
