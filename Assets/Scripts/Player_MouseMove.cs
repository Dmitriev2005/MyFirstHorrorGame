using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MouseMove : MonoBehaviour
{
    [Header("Чувствительность мыши")]
    [Range(100f, 500f)]
    public float sensitivity = 5f;
    public float yCordinat = 0f;
    public Transform Player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        yCordinat -= y;
        yCordinat = Mathf.Clamp(yCordinat, -45f, 45f);

        transform.localRotation = Quaternion.Euler(yCordinat, 0f, 0f);
        Player.Rotate(Vector3.up * x);
    }

}
