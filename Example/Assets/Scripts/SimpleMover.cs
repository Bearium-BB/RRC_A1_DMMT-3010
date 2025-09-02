using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMover : MonoBehaviour
{
    public bool enableMovement = true;
    public bool enableRotation = true;
    public float speed = 1.0f;
    public float speedRotation = 1.0f;

    public Vector2 direction = Vector2.up;

    public Space space = Space.Self;

    // Update is called once per frame
    void Update()
    {
        if (enableMovement)
        {
            MoveObject();
        }

        if (enableRotation)
        {
            RotationObject();
        }
    }

    private void MoveObject()
    {
        transform.Translate(direction * speed * Time.deltaTime, space);

    }

    private void RotationObject()
    {
        transform.Rotate(new Vector3(0,0, speedRotation) * Time.deltaTime);
    }
}
