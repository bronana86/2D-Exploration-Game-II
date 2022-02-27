using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class FirstRoomTrigger : MonoBehaviour
{
    [SerializeField]
    public Transform RoomDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        RoomDoor.position = new Vector2(-20.0f, -20.0f);
    }
}
