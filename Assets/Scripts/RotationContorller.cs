using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationContorller : MonoBehaviour
{
    public GameObject PlanetObject;
    public Vector3 RotationVector;

    void Update()
    {
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }

}
