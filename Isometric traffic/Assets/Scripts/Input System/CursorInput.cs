using UnityEngine;

public class CursorInput : MonoBehaviour
{
    private CursorControls controls;
    private Camera mainCamera;


    private void Awake()
    {
        controls = new CursorControls();
        controls.Mouse.LeftClick.started += _ => LMBClicked();
        //control.Mouse.LeftClick.performed += _ => LMBClicked(); //Called when LMB release

        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    /// <summary>
    /// Called when press LMB
    /// </summary>
    private void LMBClicked()
    {
        DetectObject();
    }

    private void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.MousePosition.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) & hit.collider != null)
        {
            IRoadClicked clicked = hit.collider.GetComponent<IRoadClicked>();
            if (clicked != null)
                clicked.Click();
        }
    }
}
