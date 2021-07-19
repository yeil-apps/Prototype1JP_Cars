using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;
    [SerializeField] private float _turnSpeed = 200f;
    private float _horizontalInput;
    private float _forwardInput;

    public string inputID;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode viewSwitchKey;

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal" + inputID);
        _forwardInput = Input.GetAxis("Vertical" + inputID);

        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _forwardInput);
        transform.Rotate(Vector3.up, _turnSpeed * Time.deltaTime * _horizontalInput);

        if (Input.GetKeyDown(viewSwitchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
