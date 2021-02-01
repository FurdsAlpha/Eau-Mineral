// GENERATED AUTOMATICALLY FROM 'Assets/Actions/Move.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Move : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Move()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Move"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""0d2e6331-607b-45c0-a603-968df3810bf9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""347a48de-33b7-4259-abaa-ddf3f318cf1a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interagir"",
                    ""type"": ""Button"",
                    ""id"": ""4e27b07c-6d7d-476e-9a50-380aa39662d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UtiliserArme"",
                    ""type"": ""Button"",
                    ""id"": ""100e2aeb-cd63-47f1-927d-f01125a135d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UtiliserPouvoir"",
                    ""type"": ""Button"",
                    ""id"": ""5c7c743c-274c-4ead-8584-c886a32575d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UtiliserConsommable"",
                    ""type"": ""Button"",
                    ""id"": ""57b73a60-0767-4085-bb0e-316f08c5de0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Flèche"",
                    ""id"": ""2464e204-bb48-4e51-a422-9c2c78a761e3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5f8d156e-9a9a-4b44-b68f-9cd6d325d4b3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e1d499c9-182a-421d-965a-e56008786b37"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2a6160b6-6fa3-4098-9cc9-1c7756061823"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3f74db35-e580-4b81-9133-a15b18932e84"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""80179ee0-ac94-4698-8c5a-4130172d3997"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2845389c-0482-415f-a283-17d5a93176b5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Interagir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2c359e9-3fb2-4d73-9171-557e73c78fb5"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Interagir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""643beb94-3497-45f1-ba1a-86e6ad6b06cb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""UtiliserArme"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83aa16db-217f-4060-96cf-1fa8b437a46a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""UtiliserArme"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dde9695d-b778-4c00-8eb4-6523012257c8"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""UtiliserPouvoir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d733eb68-a832-4459-bc18-759506e34ad6"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""UtiliserPouvoir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd7b938e-7971-4438-bf91-c1517ab8c945"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""UtiliserConsommable"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83b80c89-b802-4a98-97de-422feee98e99"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""UtiliserConsommable"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Interagir = m_Player.FindAction("Interagir", throwIfNotFound: true);
        m_Player_UtiliserArme = m_Player.FindAction("UtiliserArme", throwIfNotFound: true);
        m_Player_UtiliserPouvoir = m_Player.FindAction("UtiliserPouvoir", throwIfNotFound: true);
        m_Player_UtiliserConsommable = m_Player.FindAction("UtiliserConsommable", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Interagir;
    private readonly InputAction m_Player_UtiliserArme;
    private readonly InputAction m_Player_UtiliserPouvoir;
    private readonly InputAction m_Player_UtiliserConsommable;
    public struct PlayerActions
    {
        private @Move m_Wrapper;
        public PlayerActions(@Move wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Interagir => m_Wrapper.m_Player_Interagir;
        public InputAction @UtiliserArme => m_Wrapper.m_Player_UtiliserArme;
        public InputAction @UtiliserPouvoir => m_Wrapper.m_Player_UtiliserPouvoir;
        public InputAction @UtiliserConsommable => m_Wrapper.m_Player_UtiliserConsommable;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Interagir.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteragir;
                @Interagir.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteragir;
                @Interagir.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteragir;
                @UtiliserArme.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUtiliserArme;
                @UtiliserArme.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUtiliserArme;
                @UtiliserArme.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUtiliserArme;
                @UtiliserPouvoir.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUtiliserPouvoir;
                @UtiliserPouvoir.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUtiliserPouvoir;
                @UtiliserPouvoir.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUtiliserPouvoir;
                @UtiliserConsommable.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUtiliserConsommable;
                @UtiliserConsommable.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUtiliserConsommable;
                @UtiliserConsommable.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUtiliserConsommable;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interagir.started += instance.OnInteragir;
                @Interagir.performed += instance.OnInteragir;
                @Interagir.canceled += instance.OnInteragir;
                @UtiliserArme.started += instance.OnUtiliserArme;
                @UtiliserArme.performed += instance.OnUtiliserArme;
                @UtiliserArme.canceled += instance.OnUtiliserArme;
                @UtiliserPouvoir.started += instance.OnUtiliserPouvoir;
                @UtiliserPouvoir.performed += instance.OnUtiliserPouvoir;
                @UtiliserPouvoir.canceled += instance.OnUtiliserPouvoir;
                @UtiliserConsommable.started += instance.OnUtiliserConsommable;
                @UtiliserConsommable.performed += instance.OnUtiliserConsommable;
                @UtiliserConsommable.canceled += instance.OnUtiliserConsommable;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteragir(InputAction.CallbackContext context);
        void OnUtiliserArme(InputAction.CallbackContext context);
        void OnUtiliserPouvoir(InputAction.CallbackContext context);
        void OnUtiliserConsommable(InputAction.CallbackContext context);
    }
}
