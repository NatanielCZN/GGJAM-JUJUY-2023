using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 7f;
    [SerializeField] private float gravity = 9.8f;
    [SerializeField] private float rotationSpeed = 1000f;
    [SerializeField] private GameObject checkPoint;
    public GameObject CheckPoint
    {
        get { return checkPoint; }
        set { checkPoint = value; }
    }

    private CharacterController characterController;

    FMODUnity.StudioEventEmitter emisorPasos;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        emisorPasos = GameObject.Find("s_pasos").GetComponent<FMODUnity.StudioEventEmitter>();
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * movementSpeed * Time.deltaTime;

        if (!characterController.isGrounded) movement.y -= gravity * Time.deltaTime;

        if (horizontalInput != 0 || verticalInput != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);

            Vector3 targetEulerAngles = targetRotation.eulerAngles;

            targetEulerAngles.x = 0;

            targetEulerAngles.z = 0;

            Quaternion newRotation = Quaternion.Euler(targetEulerAngles);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetAxis("Horizontal")!= 0 || Input.GetAxis("Vertical") != 0)
        {
            if(!emisorPasos.IsPlaying())emisorPasos.Play();
        } else {emisorPasos.Stop();}

        characterController.Move(movement);
    }

    public void TeleportTo()
    {
        characterController.enabled = false;

        transform.position = checkPoint.transform.position;

        characterController.enabled = true;
    }
    private void OnTriggerStay(Collider other) {
        if (other.tag == "sueloMadera")
        {
            emisorPasos.EventInstance.setParameterByName("tipoPasos",1);
        }
    }
}
