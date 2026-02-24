using UnityEngine;
using UnityEngine.InputSystem;

public class FP_Controller : MonoBehaviour
{
    #region General Variables
    [Header("Movement & Look")]
    [SerializeField] GameObject camHolder; //Ref en el inspector del objeto al rotar
    [SerializeField] float speed = 5f;
    [SerializeField] float crouchSpeed = 5f;
    [SerializeField] float springSpeed = 5f;
    [SerializeField] float maxForce = 5f; //Fuerza maxima de aceleración
    [SerializeField] float sensivility = 0.1f; //Sensibilidad del mouse para la rotación de la cámara


    [Header("Player State Bools")]
    [SerializeField] bool isSprinting;
    [SerializeField] bool isCrouching;


    //Variables de autoreferencia
    Rigidbody rb;

    //Variables de Input
    Vector2 moveInput;
    Vector2 lookInput;
    float loopRotation;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    #endregion


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     //Lock del cursor del raton
     Cursor. lockState = CursorLockMode.Locked; //Lockea el cursor en el centro de la pantalla  
    Cursor.visible = false; //Hace el cursor invisible
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region input  Methods 
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }
    public void OnJump(InputAction.CallbackContext context)
    {

    }
    public void OnCrouch(InputAction.CallbackContext context)
    {

    }
    public void OnSprint(InputAction.CallbackContext context)
    {
        
    }
    #endregion
}

