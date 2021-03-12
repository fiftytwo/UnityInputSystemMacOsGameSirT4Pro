using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.InputSystem.Layouts;
#if UNITY_EDITOR
using UnityEditor;
#endif


#if UNITY_STANDALONE_OSX || UNITY_EDITOR
namespace Fiftytwo
{
#if UNITY_EDITOR
    [InitializeOnLoad]
#endif
    [InputControlLayout(stateType = typeof(MacOSGameSirT4ProControllerHIDInputReport), displayName = "macOS Game Sir Controller")]
    [UnityEngine.Scripting.Preserve]
    public class MacOSGameSirT4ProController : Gamepad
    {
#if UNITY_EDITOR
        static MacOSGameSirT4ProController ()
        {
            Init();
        }
#endif
 
        [RuntimeInitializeOnLoadMethod]
        private static void Init ()
        {
            InputSystem.RegisterLayout<MacOSGameSirT4ProController>(
                null,
                new InputDeviceMatcher()
                    .WithProduct( "GamepadX" ) );
        }
    }
    
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    struct MacOSGameSirT4ProControllerHIDInputReport : IInputStateTypeInfo
    {
     public FourCC format => new FourCC('H', 'I', 'D');

        [FieldOffset(0)]
        private byte padding;

        [InputControl(name = "leftStick", layout = "Stick", format = "VC2S")]
        [InputControl(name = "leftStick/x", offset = 0, format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
        [InputControl(name = "leftStick/left", offset = 0, format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
        [InputControl(name = "leftStick/right", offset = 0, format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
        [InputControl(name = "leftStick/y", offset = 2, format = "USHT", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
        [InputControl(name = "leftStick/up", offset = 2, format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
        [InputControl(name = "leftStick/down", offset = 2, format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
        [FieldOffset(1)] public byte leftStickX;
        [FieldOffset(3)] public byte leftStickY;
        
        [InputControl(name = "rightStick", layout = "Stick", format = "VC2S")]
        [InputControl(name = "rightStick/x", offset = 0, format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
        [InputControl(name = "rightStick/left", offset = 0, format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
        [InputControl(name = "rightStick/right", offset = 0, format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
        [InputControl(name = "rightStick/y", offset = 2, format = "USHT", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
        [InputControl(name = "rightStick/up", offset = 2, format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
        [InputControl(name = "rightStick/down", offset = 2, format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
        [FieldOffset(5)] public byte rightStickX;
        [FieldOffset(7)] public byte rightStickY;

        [InputControl(name = "leftTrigger", format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=0.01560998")]
        [FieldOffset(9)] public byte leftTrigger;
        [InputControl(name = "rightTrigger", format = "USHT", parameters = "normalize,normalizeMin=0,normalizeMax=0.01560998")]
        [FieldOffset(11)] public byte rightTrigger;

        [InputControl(name = "dpad", format = "BIT", layout = "Dpad", sizeInBits = 4, defaultState = 8)]
        [InputControl(name = "dpad/up", format = "BIT", layout = "DiscreteButton", parameters = "minValue=8,maxValue=2,nullValue=0,wrapAtValue=9", bit = 0, sizeInBits = 4)]
        [InputControl(name = "dpad/right", format = "BIT", layout = "DiscreteButton", parameters = "minValue=2,maxValue=4", bit = 0, sizeInBits = 4)]
        [InputControl(name = "dpad/down", format = "BIT", layout = "DiscreteButton", parameters = "minValue=4,maxValue=6", bit = 0, sizeInBits = 4)]
        [InputControl(name = "dpad/left", format = "BIT", layout = "DiscreteButton", parameters = "minValue=6, maxValue=8", bit = 0, sizeInBits = 4)]
        [FieldOffset(13)] public byte dpad;

        [InputControl(name = "buttonSouth", displayName = "A", format = "BIT", bit = 0)]
        [InputControl(name = "buttonEast", displayName = "B", format = "BIT", bit = 1)]
        [InputControl(name = "buttonWest", displayName = "X", format = "BIT", bit = 2)]
        [InputControl(name = "buttonNorth", displayName = "Y", format = "BIT", bit = 3)]
        [InputControl(name = "leftShoulder", format = "BIT", bit = 4)]
        [InputControl(name = "rightShoulder", format = "BIT", bit = 5)]
        [InputControl(name = "select", displayName = "Select", format = "BIT", bit = 6)]
        [InputControl(name = "start", displayName = "Start", format = "BIT", bit = 7)]
        [FieldOffset(14)] public byte buttons;

        [InputControl(name = "leftStickPress", format = "BIT", bit = 0)]
        [InputControl(name = "rightStickPress",format = "BIT", bit = 1)]
        [FieldOffset(15)] public byte stickPress;
    }
}
#endif
