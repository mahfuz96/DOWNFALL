using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float move_speed = 3f;
    public float bound_Y = -8f;

    public bool is_Platform,left_Platform,right_Platform;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 temp = transform.position;
        temp.y += move_speed * Time.deltaTime;
        transform.position = temp;

        if(temp.y >= bound_Y)
        {
            gameObject.SetActive(false);
        }
    }
}
