using UnityEngine;

public class InnertubeFollow : MonoBehaviour
{
    public Rigidbody playerRb;
    public float ropeLength = 1.0f;

    private ConfigurableJoint configurableJoint;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

        configurableJoint = gameObject.AddComponent<ConfigurableJoint>();
        configurableJoint.connectedBody = playerRb;

        // Lock all motion except along Z axis
        configurableJoint.xMotion = ConfigurableJointMotion.Locked;
        configurableJoint.yMotion = ConfigurableJointMotion.Locked;
        configurableJoint.zMotion = ConfigurableJointMotion.Limited;

        SoftJointLimit limit = new SoftJointLimit();
        limit.limit = ropeLength;
        configurableJoint.linearLimit = limit;

        // Allow angular swing
        configurableJoint.angularXMotion = ConfigurableJointMotion.Free;
        configurableJoint.angularYMotion = ConfigurableJointMotion.Free;
        configurableJoint.angularZMotion = ConfigurableJointMotion.Free;

        // High spring value means tight rope, low damper means more swinging
        configurableJoint.linearLimitSpring = new SoftJointLimitSpring { spring = 5000000000000f, damper = 50f};
    }
}