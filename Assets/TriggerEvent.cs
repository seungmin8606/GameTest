using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    private int JumpCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.GetComponent<Movement2D>().currentJumpCount = 1;
    }
}
