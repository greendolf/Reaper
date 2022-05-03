using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeMovement : MonoBehaviour
{
    public float speed; 
    public float angrySpeed;

    public int posOfPatrol;
    public Transform point;

    bool movingRight = false;
    bool facingRight = false;

    public float stopDistance;

    bool chill = false;
    bool angry = false;
    bool goBack = false;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, point.position) < posOfPatrol && angry == false)
        {
            chill = true;
        }
        if (Vector2.Distance(transform.position, player.position) < stopDistance)
        {
            angry = true;
            chill = false;
            goBack = false;
        }
        if (Vector2.Distance(transform.position, player.position) > stopDistance)
        {
            goBack = true;
            angry = false;
        }

        if(chill)
        {
            Chill();
        }
        else if (angry)
        {
            Angry();
        }
        else if (goBack)
        {
            GoBack();
        }

        if (facingRight == false && movingRight)
        {
            Flip();
        }
        else if (facingRight == true && !movingRight)
        {
            Flip();
        }
    }

    void Chill()
    {
        if(transform.position.x > point.position.x + posOfPatrol)
        {
            movingRight = false;
        }
        else if (transform.position.x < point.position.x - posOfPatrol)
        {
            movingRight = true;
        }
        if(movingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void Angry()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, angrySpeed * Time.deltaTime);
    }

    void GoBack()
    {
        transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
    }
}
