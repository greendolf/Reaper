using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float zpos = -10f;
    public Transform player;
    private Vector3 pos;

    public float leftLimit;
    public float rightLimit;
    public float upLimit;
    public float bottomLimit;

    // Start is called before the first frame update
    /*private void Awake()
    {
        if (!player)
            Player1 = FindObjectOfType<Hero>().transform;
    }*/

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(transform.position.y, bottomLimit, upLimit),
            transform.position.z
            );
        pos = player.position;
        pos.z = zpos;
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
    }
}
