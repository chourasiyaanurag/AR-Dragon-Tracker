using UnityEngine;

public class DragonJoystickController : MonoBehaviour
{
    public float moveSpeed = 0.1f;

    private Joystick joystick;

    void Start()
    {
        joystick = FindFirstObjectByType<Joystick>();
    }

    void Update()
    {
        if (joystick == null)
            return;

        float x = joystick.Horizontal;
        float z = joystick.Vertical;

        Vector3 movement = new Vector3(x, 0f, z);

        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}