using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog : MonoBehaviour
{
    public GameObject mailman;
    public float movementSpeed = 4;
    void Update()
    {
        transform.LookAt(mailman.transform);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
}
