using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            // Debug.Log("Lookout Below!");
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
