using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class jumpPad : MonoBehaviour
{
    public float boost = 500f;
    private void OnCollisionStay(Collision other)
    {
        other.collider.GetComponent<Rigidbody>().AddForce(Vector3.up * boost);
    }
}
