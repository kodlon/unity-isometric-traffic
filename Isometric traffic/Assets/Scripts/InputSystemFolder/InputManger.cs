using Roads;
using UnityEngine;

namespace InputSystemFolder
{
    public class InputManger : MonoBehaviour
    {
        private InputSystem _inputSystem;
        private Camera _mainCamera;


        private void Awake()
        {
            _inputSystem = new InputSystem();
            _inputSystem.Touch.Touched.started += _ => TouchedScreen();
            //control.Mouse.LeftClick.performed += _ => LMBClicked(); //Called when LMB release

            _mainCamera = Camera.main;
        }

        private void OnEnable()
        {
            _inputSystem.Enable();
        }

        private void OnDisable()
        {
            _inputSystem.Disable();
        }

        private void TouchedScreen()
        {
            DetectObject();
        }

//#if UNITY_ANDROID
        //TODO: For android and pc different Input
//#endif
        private void DetectObject()
        {
            Ray ray = _mainCamera.ScreenPointToRay(_inputSystem.Touch.TouchPosition.ReadValue<Vector2>());
            if (Physics.Raycast(ray, out RaycastHit hit) & hit.collider != null) //BUG: first touch don`t got hit an object
            {
                IRoad clicked = hit.collider.GetComponent<IRoad>();
                clicked?.Click();
            }
        }
    }
}