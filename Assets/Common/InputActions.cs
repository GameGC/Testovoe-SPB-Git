// GENERATED AUTOMATICALLY FROM 'Assets/Samples/Common/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""CharacterController"",
            ""id"": ""df70fa95-8a34-4494-b137-73ab6b9c7d37"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""351f2ccd-1f9f-44bf-9bec-d62ac5c5f408"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""6b444451-8a00-4d00-a97e-f47457f736a8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Value"",
                    ""id"": ""6c2ab1b8-8984-453a-af3d-a3c78ae1679a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""69752feb-cc7c-4543-91d2-0ace8d69c4d5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978bfe49-cc26-4a3d-ab7b-7d7a29327403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c1f7a91b-d0fd-4a62-997e-7fb9b69bf235"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c8e490b-c610-4785-884f-f04217b23ca4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""143bb1cd-cc10-4eca-a2f0-a3664166fe91"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05f6913d-c316-48b2-a6bb-e225f14c7960"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3433dd64-4e10-4bd3-90ee-b56b53fe053d"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""408affec-e813-4405-87e5-3b5cebe51fe1"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39c1bb66-45e8-4cf0-9965-8ff02b571a1f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c02b78e4-061e-46d2-bbac-d2f70353919f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""272f6d14-89ba-496f-b7ff-215263d3219f"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""c95b2375-e6d9-4b88-9c4c-c5e76515df4b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Value"",
                    ""id"": ""7607c7b6-cd76-4816-beef-bd0341cfe950"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Value"",
                    ""id"": ""15cef263-9014-4fd5-94d9-4e4a6234a6ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""32b35790-4ed0-4e9a-aa41-69ac6d629449"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3c7022bf-7922-4f7c-a998-c437916075ad"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0489e84a-4833-4c40-bfae-cea84b696689"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dad70c86-b58c-4b17-88ad-f5e53adf419e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""44b200b1-1557-4083-816c-b22cbdf77ddf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""809f371f-c5e2-4e7a-83a1-d867598f40dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2db08d65-c5fb-421b-983f-c71163608d67"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba04515-75aa-45de-966d-393d9bbd1c14"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcd248ae-a788-4676-a12e-f4d81205600b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""598ce44a-397c-4e5b-92de-e8310d45318c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f56d9066-6b35-46d1-be47-6d9af6be7960"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6b86864d-99a5-4781-aa57-baa8a31b782d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""70966ee5-20f2-41cf-8f60-c566e6fa7705"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f518a588-a778-4dc4-8a44-1c4bdf655056"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c8a64c4-66ba-4860-926f-b9b20417f01c"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b20f78f-833e-4ad7-a79c-5630a2bd78d0"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52c8e0b-8179-41d3-b8a1-d149033bbe86"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b5ecda8-19c5-48c4-9c01-d24009624557"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faf7dc9-b979-4210-aa8c-e808e1ef89f5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""263af53b-9112-4f36-a902-5e3c7cedda8c"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c99815-14ea-4617-8627-164d27641299"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24066f69-da47-44f3-a07e-0015fb02eb2e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c191405-5738-4d4b-a523-c6a301dbf754"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle"",
            ""id"": ""5af4b501-ce19-423a-866c-4ce28984f562"",
            ""actions"": [
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""1d611fd2-67a0-4ee2-b7a3-96e070d338c8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""1f2945fb-7e12-4645-a84b-bd123610202e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Previous"",
                    ""type"": ""Value"",
                    ""id"": ""bec1b536-c041-4325-8ff1-34380f345179"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Value"",
                    ""id"": ""4f50fbd5-6011-4b9c-9146-3be1bd7a7cd9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""ceff8213-609d-4166-a10b-77644780add8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b4dfc346-5b76-4046-bc17-9ef7297888d3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""af1c9d17-1daa-4352-95bf-8c7505903d1d"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""208bf950-dd36-4661-b8b8-58a5e340b782"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""332ae12f-a97e-4c89-b74b-ca9bb077c15e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""b8d27dda-b4ea-4b56-81fc-1f90df8910d1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""194f469d-a4af-4a01-86c9-4ab9451863b9"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4b13aa6c-53ec-4fdf-8e38-bcb1897a8318"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""2a0c8714-353d-4149-a543-b31a6776e41d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""146c8358-ebf8-4e5e-ad16-da6125e8cd27"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""80180b38-fb21-418e-8f49-0c8979fa5da5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b8c4f3bc-183b-4703-bf36-8687415e243f"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ee6c218-ce62-40c7-9727-8eb5a2687f05"",
                    ""path"": ""<Keyboard>/leftBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae3a55c2-b2cf-4540-82b1-d0711396a9d2"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc8e2822-d1c3-484d-bca1-0ec62e1e1c00"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f171eca-531d-424d-b161-0b2d8ff74a53"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""4a9fd2e7-6ed3-48bf-9df5-5022321eb506"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7f621b70-3170-46df-a46c-ddf7a98ff69a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""821aacf2-6039-46bd-9959-1ebd1423356b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // CharacterController
        m_CharacterController = asset.FindActionMap("CharacterController", throwIfNotFound: true);
        m_CharacterControllerMove = m_CharacterController.FindAction("Move", throwIfNotFound: true);
        m_CharacterControllerLook = m_CharacterController.FindAction("Look", throwIfNotFound: true);
        m_CharacterControllerFire = m_CharacterController.FindAction("Fire", throwIfNotFound: true);
        m_CharacterControllerJump = m_CharacterController.FindAction("Jump", throwIfNotFound: true);
        // UI
        m_Ui = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UiNavigate = m_Ui.FindAction("Navigate", throwIfNotFound: true);
        m_UiSubmit = m_Ui.FindAction("Submit", throwIfNotFound: true);
        m_UiCancel = m_Ui.FindAction("Cancel", throwIfNotFound: true);
        m_UiPoint = m_Ui.FindAction("Point", throwIfNotFound: true);
        m_UiClick = m_Ui.FindAction("Click", throwIfNotFound: true);
        m_UiScrollWheel = m_Ui.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UiMiddleClick = m_Ui.FindAction("MiddleClick", throwIfNotFound: true);
        m_UiRightClick = m_Ui.FindAction("RightClick", throwIfNotFound: true);
        // Vehicle
        m_Vehicle = asset.FindActionMap("Vehicle", throwIfNotFound: true);
        m_VehicleSteering = m_Vehicle.FindAction("Steering", throwIfNotFound: true);
        m_VehicleThrottle = m_Vehicle.FindAction("Throttle", throwIfNotFound: true);
        m_VehiclePrevious = m_Vehicle.FindAction("Previous", throwIfNotFound: true);
        m_VehicleNext = m_Vehicle.FindAction("Next", throwIfNotFound: true);
        m_VehicleLook = m_Vehicle.FindAction("Look", throwIfNotFound: true);
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

    // CharacterController
    private readonly InputActionMap m_CharacterController;
    private ICharacterControllerActions m_CharacterControllerActionsCallbackInterface;
    private readonly InputAction m_CharacterControllerMove;
    private readonly InputAction m_CharacterControllerLook;
    private readonly InputAction m_CharacterControllerFire;
    private readonly InputAction m_CharacterControllerJump;
    public struct CharacterControllerActions
    {
        private @InputActions m_Wrapper;
        public CharacterControllerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction move => m_Wrapper.m_CharacterControllerMove;
        public InputAction look => m_Wrapper.m_CharacterControllerLook;
        public InputAction fire => m_Wrapper.m_CharacterControllerFire;
        public InputAction jump => m_Wrapper.m_CharacterControllerJump;
        public InputActionMap Get() { return m_Wrapper.m_CharacterController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControllerActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControllerActions instance)
        {
            if (m_Wrapper.m_CharacterControllerActionsCallbackInterface != null)
            {
                move.started -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnMove;
                move.performed -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnMove;
                move.canceled -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnMove;
                look.started -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnLook;
                look.performed -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnLook;
                look.canceled -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnLook;
                fire.started -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnFire;
                fire.performed -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnFire;
                fire.canceled -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnFire;
                jump.started -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnJump;
                jump.performed -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnJump;
                jump.canceled -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_CharacterControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                move.started += instance.OnMove;
                move.performed += instance.OnMove;
                move.canceled += instance.OnMove;
                look.started += instance.OnLook;
                look.performed += instance.OnLook;
                look.canceled += instance.OnLook;
                fire.started += instance.OnFire;
                fire.performed += instance.OnFire;
                fire.canceled += instance.OnFire;
                jump.started += instance.OnJump;
                jump.performed += instance.OnJump;
                jump.canceled += instance.OnJump;
            }
        }
    }
    public CharacterControllerActions characterController => new CharacterControllerActions(this);

    // UI
    private readonly InputActionMap m_Ui;
    private IUiActions m_UiActionsCallbackInterface;
    private readonly InputAction m_UiNavigate;
    private readonly InputAction m_UiSubmit;
    private readonly InputAction m_UiCancel;
    private readonly InputAction m_UiPoint;
    private readonly InputAction m_UiClick;
    private readonly InputAction m_UiScrollWheel;
    private readonly InputAction m_UiMiddleClick;
    private readonly InputAction m_UiRightClick;
    public struct UiActions
    {
        private @InputActions m_Wrapper;
        public UiActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction navigate => m_Wrapper.m_UiNavigate;
        public InputAction submit => m_Wrapper.m_UiSubmit;
        public InputAction cancel => m_Wrapper.m_UiCancel;
        public InputAction point => m_Wrapper.m_UiPoint;
        public InputAction click => m_Wrapper.m_UiClick;
        public InputAction scrollWheel => m_Wrapper.m_UiScrollWheel;
        public InputAction middleClick => m_Wrapper.m_UiMiddleClick;
        public InputAction rightClick => m_Wrapper.m_UiRightClick;
        public InputActionMap Get() { return m_Wrapper.m_Ui; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UiActions set) { return set.Get(); }
        public void SetCallbacks(IUiActions instance)
        {
            if (m_Wrapper.m_UiActionsCallbackInterface != null)
            {
                navigate.started -= m_Wrapper.m_UiActionsCallbackInterface.OnNavigate;
                navigate.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnNavigate;
                navigate.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnNavigate;
                submit.started -= m_Wrapper.m_UiActionsCallbackInterface.OnSubmit;
                submit.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnSubmit;
                submit.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnSubmit;
                cancel.started -= m_Wrapper.m_UiActionsCallbackInterface.OnCancel;
                cancel.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnCancel;
                cancel.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnCancel;
                point.started -= m_Wrapper.m_UiActionsCallbackInterface.OnPoint;
                point.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnPoint;
                point.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnPoint;
                click.started -= m_Wrapper.m_UiActionsCallbackInterface.OnClick;
                click.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnClick;
                click.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnClick;
                scrollWheel.started -= m_Wrapper.m_UiActionsCallbackInterface.OnScrollWheel;
                scrollWheel.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnScrollWheel;
                scrollWheel.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnScrollWheel;
                middleClick.started -= m_Wrapper.m_UiActionsCallbackInterface.OnMiddleClick;
                middleClick.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnMiddleClick;
                middleClick.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnMiddleClick;
                rightClick.started -= m_Wrapper.m_UiActionsCallbackInterface.OnRightClick;
                rightClick.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnRightClick;
                rightClick.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnRightClick;
            }
            m_Wrapper.m_UiActionsCallbackInterface = instance;
            if (instance != null)
            {
                navigate.started += instance.OnNavigate;
                navigate.performed += instance.OnNavigate;
                navigate.canceled += instance.OnNavigate;
                submit.started += instance.OnSubmit;
                submit.performed += instance.OnSubmit;
                submit.canceled += instance.OnSubmit;
                cancel.started += instance.OnCancel;
                cancel.performed += instance.OnCancel;
                cancel.canceled += instance.OnCancel;
                point.started += instance.OnPoint;
                point.performed += instance.OnPoint;
                point.canceled += instance.OnPoint;
                click.started += instance.OnClick;
                click.performed += instance.OnClick;
                click.canceled += instance.OnClick;
                scrollWheel.started += instance.OnScrollWheel;
                scrollWheel.performed += instance.OnScrollWheel;
                scrollWheel.canceled += instance.OnScrollWheel;
                middleClick.started += instance.OnMiddleClick;
                middleClick.performed += instance.OnMiddleClick;
                middleClick.canceled += instance.OnMiddleClick;
                rightClick.started += instance.OnRightClick;
                rightClick.performed += instance.OnRightClick;
                rightClick.canceled += instance.OnRightClick;
            }
        }
    }
    public UiActions ui => new UiActions(this);

    // Vehicle
    private readonly InputActionMap m_Vehicle;
    private IVehicleActions m_VehicleActionsCallbackInterface;
    private readonly InputAction m_VehicleSteering;
    private readonly InputAction m_VehicleThrottle;
    private readonly InputAction m_VehiclePrevious;
    private readonly InputAction m_VehicleNext;
    private readonly InputAction m_VehicleLook;
    public struct VehicleActions
    {
        private @InputActions m_Wrapper;
        public VehicleActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction steering => m_Wrapper.m_VehicleSteering;
        public InputAction throttle => m_Wrapper.m_VehicleThrottle;
        public InputAction previous => m_Wrapper.m_VehiclePrevious;
        public InputAction next => m_Wrapper.m_VehicleNext;
        public InputAction look => m_Wrapper.m_VehicleLook;
        public InputActionMap Get() { return m_Wrapper.m_Vehicle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleActions instance)
        {
            if (m_Wrapper.m_VehicleActionsCallbackInterface != null)
            {
                steering.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteering;
                steering.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteering;
                steering.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteering;
                throttle.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnThrottle;
                throttle.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnThrottle;
                throttle.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnThrottle;
                previous.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnPrevious;
                previous.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnPrevious;
                previous.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnPrevious;
                next.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnNext;
                next.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnNext;
                next.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnNext;
                look.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnLook;
                look.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnLook;
                look.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_VehicleActionsCallbackInterface = instance;
            if (instance != null)
            {
                steering.started += instance.OnSteering;
                steering.performed += instance.OnSteering;
                steering.canceled += instance.OnSteering;
                throttle.started += instance.OnThrottle;
                throttle.performed += instance.OnThrottle;
                throttle.canceled += instance.OnThrottle;
                previous.started += instance.OnPrevious;
                previous.performed += instance.OnPrevious;
                previous.canceled += instance.OnPrevious;
                next.started += instance.OnNext;
                next.performed += instance.OnNext;
                next.canceled += instance.OnNext;
                look.started += instance.OnLook;
                look.performed += instance.OnLook;
                look.canceled += instance.OnLook;
            }
        }
    }
    public VehicleActions vehicle => new VehicleActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme keyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme gamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ICharacterControllerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IUiActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
    }
    public interface IVehicleActions
    {
        void OnSteering(InputAction.CallbackContext context);
        void OnThrottle(InputAction.CallbackContext context);
        void OnPrevious(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
