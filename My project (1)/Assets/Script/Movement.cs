using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    //public Variables
    public Rigidbody2D myRigidbody;
    public PlayerMoveAction PlayerControls;
    public float moveSpeed = 5f;
    public GameObject pauseMenu;





    //private Variables
    private Vector2 movementDirection=Vector2.zero;
    private InputAction move;
    private InputAction Fire;
    private InputAction pause;
    private bool pauseState=false;
    private void Awake()
    {
        PlayerControls=new PlayerMoveAction();

    }
    
    //Enable Input Action
    void OnEnable()
    {
        PlayerControls.Enable();
        move=PlayerControls.Player.Move;
        move.Enable();

        pause=PlayerControls.Player.pause;
        pause.Enable();
        pause.performed+=Pause;

        Fire=PlayerControls.Player.Fire;
        Fire.Enable();

    }
    //Disable Input Action
    void OnDisable()
    {
        PlayerControls.Disable();

        move.Disable();

        pause.Disable();

        Fire.Disable();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    //Physics Update
    private void FixedUpdate()
    {
        movementDirection = move.ReadValue<Vector2>();
        myRigidbody.linearVelocity = movementDirection * moveSpeed;
    }





    //Pause Menu Toggle
        public void TogglePause()
        {
         if(pauseState)
         {
             pauseMenu.SetActive(false);
              Time.timeScale=1f;
             pauseState=false;
          }
         else
          {
             pauseMenu.SetActive(true);
             Time.timeScale=0f;
              pauseState=true;
          }
        }
    
    
    
    
    
    
        //Pause Input Action Callback    
        private void Pause(InputAction.CallbackContext context)
        {
        TogglePause();
        }





        // Back to Main Menu
        public void BacktoMenu()
        {

        SceneManager.LoadScene(0);
         Time.timeScale=1f;
        }
}
