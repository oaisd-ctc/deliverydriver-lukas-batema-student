using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new(204, 208, 209, 255);
    [SerializeField] Color32 hasNotPackageColor = new(137, 149, 154, 255);

    [SerializeField] float destroyDelay = 1f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = hasNotPackageColor;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("OOOOOOOOOOOOOOOOOOOOOOOOOOF");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyDelay);
            hasPackage = true;
            Debug.Log("Package picked up.");
        }

        if (collision.tag == "Customer" && hasPackage)
        {
            spriteRenderer.color = hasNotPackageColor;
            hasPackage = false;
            Debug.Log("Package Delivered");
        }
    }
}
