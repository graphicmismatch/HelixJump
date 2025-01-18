using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class RotationController : MonoBehaviour
{
    [SerializeField]
    float TurnSpeed;

    float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down * t * Time.deltaTime * TurnSpeed);
    }

    public void onMove(InputAction.CallbackContext ctx) {
        var i = ctx.ReadValue<float>();

        transform.Rotate(Vector3.down * i * Time.deltaTime*10);
    }

    public void onKeeb(InputAction.CallbackContext ctx)
    {
        t = ctx.ReadValue<float>();

            
    }
}
