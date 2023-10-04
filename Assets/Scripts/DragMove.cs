using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
public class DragMove : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cam;
    [SerializeField] private Transform LookAt;
    [SerializeField] private float movementSpeed;
    
    private bool isPressed;

    public void BackToUp()
    {
        cam.Follow = transform;
        cam.LookAt = LookAt;
    }
    public void OnBack()
    {
        BackToUp();
    }
    public void SetUnder(Vector3 value)
    {
        Vector3 deltaBetween = LookAt.position - transform.position;
        transform.position = new Vector3((value - deltaBetween).x, transform.position.y, (value - deltaBetween).z);
    }
    public void OnMousePosition(InputValue value)
    {
        Vector2 delta = value.Get<Vector2>();
        if (!isPressed) return;
        transform.position -= (Vector3.right * delta.x + Vector3.forward * delta.y) * movementSpeed;
    }
    public void OnFire(InputValue value)
    {
        isPressed = value.isPressed;
    }
}
