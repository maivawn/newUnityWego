using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offet = new Vector3 (0, 0, -15);
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("GamePlay").transform;
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = player.transform.position + offet;
    }
}
