using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Border")
        {
            float moveAmount = Input.GetAxis("Vertical") * -15f * Time.deltaTime;
            transform.Translate(0, moveAmount, 0);
        }
    }
}
