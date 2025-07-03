using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(0.01f, 0f);
    }
}
