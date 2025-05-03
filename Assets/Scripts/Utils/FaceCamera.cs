using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.activeSelf)
        {
            transform.LookAt(Camera.main.transform);
            transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, 0f);
        }
    }
}
