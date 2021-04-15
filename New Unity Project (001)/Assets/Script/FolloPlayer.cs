using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolloPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 Offset = new Vector3(0.6f, 6.75f, -12);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + Offset;
    }
}
