using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour {
    //public Vector3 jumpVector;
    // Use this for initialization
    public float jumpElevationInDegrees = 45;
    public float[] jumpSpeedInCMPS = { 200, 500, 700};
    public int hopCount = 0;
    public float jumpGroundClearance = 2;
    public float jumpSpeedTolerance = 5;

    public int collisionCount = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Camera camera = GetComponentInChildren<Camera>();
        //GvrViewer.Instance.Triggered
        bool isOnGround = collisionCount > 0;
        if (isOnGround)
            hopCount = 0;
        var speed = GetComponent<Rigidbody>().velocity.magnitude;
        if (GvrViewer.Instance.Triggered && hopCount < jumpSpeedInCMPS.Length)
        {
            
            var projectedLookDirection = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
            var radiansToRotate = Mathf.Deg2Rad * jumpElevationInDegrees;
            var unnormalizedJumpDirection = Vector3.RotateTowards(projectedLookDirection, Vector3.up, radiansToRotate, 0);
            var jumpVector = unnormalizedJumpDirection.normalized * jumpSpeedInCMPS[hopCount];

            GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange);
            hopCount++;
        }
	}

    void OnCollisionEnter()
    {
        collisionCount++;
    }

    void OnCollisionExit()
    {
        collisionCount--;
    }
}
