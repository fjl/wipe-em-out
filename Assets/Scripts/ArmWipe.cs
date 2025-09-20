using UnityEngine;
using UnityEngine.InputSystem;

public class ArmWipe : MonoBehaviour
{
    public Camera mainCamera;
    [Header("Input")]
    public InputActionProperty LookPosAction;
    public Transform debugTarget;
    public Transform shoulder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPoint = Vector3.zero;
        Ray ray = mainCamera.ScreenPointToRay(LookPosAction.action.ReadValue<Vector2>());
        Plane ground = new Plane(Vector3.up, Vector3.zero);
        if (ground.Raycast(ray, out float dist))
        {
            targetPoint = ray.GetPoint(dist);
            Vector3 dir = targetPoint - transform.position;
            dir.y = 0;
            //if (dir.sqrMagnitude > 0.01f)
            //    transform.rotation = Quaternion.LookRotation(dir.normalized);
        }

        shoulder.rotation.SetLookRotation(targetPoint - shoulder.position, Vector3.up);
    }
}
