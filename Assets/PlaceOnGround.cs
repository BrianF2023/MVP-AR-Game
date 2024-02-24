using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceOnGround : MonoBehaviour
{
    public Transform target;
    public float raycastDistance = 2;
    public LayerMask layerMask;
    public float radius = 0.2f;
    public float verticalOffset = 0.02f;


    // Update is called once per frame
    void Update()
    {
        RaycastHit raycastHit;

        bool hasHit = Physics.SphereCast(target.position, radius, Vector3.down, out raycastHit, raycastDistance, layerMask);

        if(hasHit)
        {
            transform.position = new Vector3(target.position.x, raycastHit.point.y + verticalOffset, target.position.z);
        }
    }
}
