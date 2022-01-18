using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMoveScript : MonoBehaviour
{
    public float speed = 1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
