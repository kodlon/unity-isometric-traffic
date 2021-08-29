// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputSystemFolder/InputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""9975e168-03c4-448e-8a54-8dcbbb9a56c0"",
            ""actions"": [
                {
                    ""name"": ""Touch Input"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f3600680-0137-428e-9fe4-95a86f41ca13"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Touched"",
                    ""type"": ""Button"",
                    ""id"": ""cb9c3193-786c-4f79-9e9b-cbd53dbead10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Touch Position"",
                    ""type"": ""Value"",
                    ""id"": ""ea8e4eb3-3b2a-4e1e-aea5-db5249dcbbc4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0e05b5f1-1d44-474c-9df8-4330f4228c41"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc819d9c-0b66-4a88-9b59-c910108c1a84"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touched"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12b1c911-23f1-4988-b2f4-e8eabfe43c18"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touched"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""486c9838-e1e4-4f78-9cc7-61cf56a9ad84"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9193bbd-f81a-4833-bf27-d2aa7d234123"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_TouchInput = m_Touch.FindAction("Touch Input", throwIfNotFound: true);
        m_Touch_Touched = m_Touch.FindAction("Touched", throwIfNotFound: true);
        m_Touch_TouchPosition = m_Touch.FindAction("Touch Position", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_TouchInput;
    private readonly InputAction m_Touch_Touched;
    private readonly InputAction m_Touch_TouchPosition;
    public struct TouchActions
    {
        private @InputSystem m_Wrapper;
        public TouchActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchInput => m_Wrapper.m_Touch_TouchInput;
        public InputAction @Touched => m_Wrapper.m_Touch_Touched;
        public InputAction @TouchPosition => m_Wrapper.m_Touch_TouchPosition;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @TouchInput.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchInput;
                @TouchInput.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchInput;
                @TouchInput.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchInput;
                @Touched.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouched;
                @Touched.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouched;
                @Touched.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouched;
                @TouchPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPosition;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TouchInput.started += instance.OnTouchInput;
                @TouchInput.performed += instance.OnTouchInput;
                @TouchInput.canceled += instance.OnTouchInput;
                @Touched.started += instance.OnTouched;
                @Touched.performed += instance.OnTouched;
                @Touched.canceled += instance.OnTouched;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    public interface ITouchActions
    {
        void OnTouchInput(InputAction.CallbackContext context);
        void OnTouched(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
    }
}
