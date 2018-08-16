using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using VRTK;
using VrtkRx.Triggers;

namespace VrtkRx
{
    public static class VRTXrxObservableTriggers
    {
        #region Controller events
        #region ObservableOnTriggerPressedTrigger
        /// <summary>
        /// Controller Trigger Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerPressedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTriggerPressedTrigger>(controllerEvent.gameObject);
            controllerEvent.TriggerPressed += component.OnTriggerPressed;

            return component.OnTriggerPressedAsObservable();
        }
        #endregion

        #region ObservableOnTriggerReleasedTrigger
        /// <summary>
        /// Controller Trigger Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerReleasedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTriggerReleasedTrigger>(controllerEvent.gameObject);
            controllerEvent.TriggerReleased += component.OnTriggerReleased;

            return component.OnTriggerReleasedAsObservable();
        }
        #endregion

        #region ObservableOnTriggerTouchStartTrigger
        /// <summary>
        /// Controller Trigger Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTriggerTouchStartTrigger>(controllerEvent.gameObject);
            controllerEvent.TriggerTouchStart += component.OnTriggerTouchStart;

            return component.OnTriggerTouchStartAsObservable();
        }
        #endregion

        #region ObservableOnTriggerTouchEndTrigger
        /// <summary>
        /// Controller Trigger Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTriggerTouchEndTrigger>(controllerEvent.gameObject);
            controllerEvent.TriggerTouchEnd += component.OnTriggerTouchEnd;

            return component.OnTriggerTouchEndAsObservable();
        }
        #endregion

        #region ObservableOnTriggerHairlineStartTrigger
        /// <summary>
        ///  Controller Trigger Hairline Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerHairlineStartAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTriggerHairlineStartTrigger>(controllerEvent.gameObject);
            controllerEvent.TriggerHairlineStart += component.OnTriggerHairlineStart;

            return component.OnTriggerHairlineStartAsObservable();
        }
        #endregion

        #region ObservableOnTriggerHairlineEndTrigger
        /// <summary>
        ///  Controller Trigger Hairline End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerHairlineEndAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTriggerHairlineEndTrigger>(controllerEvent.gameObject);
            controllerEvent.TriggerHairlineEnd += component.OnTriggerHairlineEnd;

            return component.OnTriggerHairlineEndAsObservable();
        }
        #endregion

        #region ObservableOnTriggerClickedTrigger
        /// <summary>
        ///  Controller Trigger Clicked
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerClickedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTriggerClickedTrigger>(controllerEvent.gameObject);
            controllerEvent.TriggerClicked += component.OnTriggerClicked;

            return component.OnTriggerClickedAsObservable();
        }
        #endregion

        #region ObservableOnTriggerUnclickedTrigger
        /// <summary>
        ///  Controller Trigger Unclicked
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerUnclickedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTriggerUnclickedTrigger>(controllerEvent.gameObject);
            controllerEvent.TriggerUnclicked += component.OnTriggerUnclicked;

            return component.OnTriggerUnclickedAsObservable();
        }
        #endregion

        #region ObservableOnTriggerAxisChangedTrigger
        /// <summary>
        ///  Controller Trigger AxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTriggerAxisChangedTrigger>(controllerEvent.gameObject);
            controllerEvent.TriggerAxisChanged += component.OnTriggerAxisChanged;

            return component.OnTriggerAxisChangedAsObservable();
        }
        #endregion

        #region ObservableOnTriggerSenseAxisChangedTrigger
        /// <summary>
        ///  Controller Trigger SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTriggerSenseAxisChangedTrigger>(controllerEvent.gameObject);
            controllerEvent.TriggerSenseAxisChanged += component.OnTriggerSenseAxisChanged;

            return component.OnTriggerSenseAxisChangedAsObservable();
        }
        #endregion

        #region ObservableOnGripPressedTrigger
        /// <summary>
        /// Controller Grip Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripPressedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnGripPressedTrigger>(controllerEvent.gameObject);
            controllerEvent.GripPressed += component.OnGripPressed;

            return component.OnGripPressedAsObservable();
        }
        #endregion

        #region ObservableOnGripReleasedTrigger
        /// <summary>
        /// Controller Grip Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripReleasedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnGripReleasedTrigger>(controllerEvent.gameObject);
            controllerEvent.GripReleased += component.OnGripReleased;

            return component.OnGripReleasedAsObservable();
        }
        #endregion

        #region ObservableOnGripTouchStartTrigger
        /// <summary>
        /// Controller Grip Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnGripTouchStartTrigger>(controllerEvent.gameObject);
            controllerEvent.GripTouchStart += component.OnGripTouchStart;

            return component.OnGripTouchStartAsObservable();
        }
        #endregion

        #region ObservableOnGripTouchEndTrigger
        /// <summary>
        /// Controller Grip Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnGripTouchEndTrigger>(controllerEvent.gameObject);
            controllerEvent.GripTouchEnd += component.OnGripTouchEnd;

            return component.OnGripTouchEndAsObservable();
        }
        #endregion

        #region ObservableOnGripHairlineStartTrigger
        /// <summary>
        ///  Controller Grip Hairline Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripHairlineStartAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnGripHairlineStartTrigger>(controllerEvent.gameObject);
            controllerEvent.GripHairlineStart += component.OnGripHairlineStart;

            return component.OnGripHairlineStartAsObservable();
        }
        #endregion

        #region ObservableOnGripHairlineEndTrigger
        /// <summary>
        ///  Controller Grip Hairline End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripHairlineEndAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnGripHairlineEndTrigger>(controllerEvent.gameObject);
            controllerEvent.GripHairlineEnd += component.OnGripHairlineEnd;

            return component.OnGripHairlineEndAsObservable();
        }
        #endregion

        #region ObservableOnGripClickedTrigger
        /// <summary>
        ///  Controller Grip Clicked
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripClickedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnGripClickedTrigger>(controllerEvent.gameObject);
            controllerEvent.GripClicked += component.OnGripClicked;

            return component.OnGripClickedAsObservable();
        }
        #endregion

        #region ObservableOnGripUnclickedTrigger
        /// <summary>
        ///  Controller Grip Unclicked
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripUnclickedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnGripUnclickedTrigger>(controllerEvent.gameObject);
            controllerEvent.GripUnclicked += component.OnGripUnclicked;

            return component.OnGripUnclickedAsObservable();
        }
        #endregion

        #region ObservableOnGripAxisChangedTrigger
        /// <summary>
        ///  Controller Grip AxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnGripAxisChangedTrigger>(controllerEvent.gameObject);
            controllerEvent.GripAxisChanged += component.OnGripAxisChanged;

            return component.OnGripAxisChangedAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadPressedTrigger
        /// <summary>
        /// Controller Touchpad Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadPressedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadPressedTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadPressed += component.OnTouchpadPressed;

            return component.OnTouchpadPressedAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadReleasedTrigger
        /// <summary>
        /// Controller Touchpad Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadReleasedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadReleasedTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadReleased += component.OnTouchpadReleased;

            return component.OnTouchpadReleasedAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadTouchStartTrigger
        /// <summary>
        /// Controller Touchpad Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadTouchStartTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadTouchStart += component.OnTouchpadTouchStart;

            return component.OnTouchpadTouchStartAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadTouchEndTrigger
        /// <summary>
        /// Controller Touchpad Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadTouchEndTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadTouchEnd += component.OnTouchpadTouchEnd;

            return component.OnTouchpadTouchEndAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadAxisChangedTrigger
        /// <summary>
        ///  Controller Touchpad AxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadAxisChangedTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadAxisChanged += component.OnTouchpadAxisChanged;

            return component.OnTouchpadAxisChangedAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadSenseAxisChangedTrigger
        /// <summary>
        ///  Controller Touchpad SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadSenseAxisChangedTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadSenseAxisChanged += component.OnTouchpadSenseAxisChanged;

            return component.OnTouchpadSenseAxisChangedAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadTwoPressedTrigger
        /// <summary>
        /// Controller TouchpadTwo Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoPressedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadTwoPressedTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadTwoPressed += component.OnTouchpadTwoPressed;

            return component.OnTouchpadTwoPressedAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadTwoReleasedTrigger
        /// <summary>
        /// Controller TouchpadTwo Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoReleasedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadTwoReleasedTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadTwoReleased += component.OnTouchpadTwoReleased;

            return component.OnTouchpadTwoReleasedAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadTwoTouchStartTrigger
        /// <summary>
        /// Controller TouchpadTwo Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadTwoTouchStartTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadTwoTouchStart += component.OnTouchpadTwoTouchStart;

            return component.OnTouchpadTwoTouchStartAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadTwoTouchEndTrigger
        /// <summary>
        /// Controller TouchpadTwo Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadTwoTouchEndTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadTwoTouchEnd += component.OnTouchpadTwoTouchEnd;

            return component.OnTouchpadTwoTouchEndAsObservable();
        }
        #endregion

        #region ObservableOnTouchpadTwoAxisChangedTrigger
        /// <summary>
        ///  Controller TouchpadTwo AxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnTouchpadTwoAxisChangedTrigger>(controllerEvent.gameObject);
            controllerEvent.TouchpadTwoAxisChanged += component.OnTouchpadTwoAxisChanged;

            return component.OnTouchpadTwoAxisChangedAsObservable();
        }
        #endregion

        #region ObservableOnButtonOnePressedTrigger
        /// <summary>
        /// Controller ButtonOne Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOnePressedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnButtonOnePressedTrigger>(controllerEvent.gameObject);
            controllerEvent.ButtonOnePressed += component.OnButtonOnePressed;

            return component.OnButtonOnePressedAsObservable();
        }
        #endregion

        #region ObservableOnButtonOneReleasedTrigger
        /// <summary>
        /// Controller ButtonOne Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOneReleasedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnButtonOneReleasedTrigger>(controllerEvent.gameObject);
            controllerEvent.ButtonOneReleased += component.OnButtonOneReleased;

            return component.OnButtonOneReleasedAsObservable();
        }
        #endregion

        #region ObservableOnButtonOneTouchStartTrigger
        /// <summary>
        /// Controller ButtonOne Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOneTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnButtonOneTouchStartTrigger>(controllerEvent.gameObject);
            controllerEvent.ButtonOneTouchStart += component.OnButtonOneTouchStart;

            return component.OnButtonOneTouchStartAsObservable();
        }
        #endregion

        #region ObservableOnButtonOneTouchEndTrigger
        /// <summary>
        /// Controller ButtonOne Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOneTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnButtonOneTouchEndTrigger>(controllerEvent.gameObject);
            controllerEvent.ButtonOneTouchEnd += component.OnButtonOneTouchEnd;

            return component.OnButtonOneTouchEndAsObservable();
        }
        #endregion

        #region ObservableOnButtonTwoPressedTrigger
        /// <summary>
        /// Controller ButtonTwo Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoPressedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var compTwont = GetOrAddComponent<ObservableOnButtonTwoPressedTrigger>(controllerEvent.gameObject);
            controllerEvent.ButtonTwoPressed += compTwont.OnButtonTwoPressed;

            return compTwont.OnButtonTwoPressedAsObservable();
        }
        #endregion

        #region ObservableOnButtonTwoReleasedTrigger
        /// <summary>
        /// Controller ButtonTwo Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoReleasedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var compTwont = GetOrAddComponent<ObservableOnButtonTwoReleasedTrigger>(controllerEvent.gameObject);
            controllerEvent.ButtonTwoReleased += compTwont.OnButtonTwoReleased;

            return compTwont.OnButtonTwoReleasedAsObservable();
        }
        #endregion

        #region ObservableOnButtonTwoTouchStartTrigger
        /// <summary>
        /// Controller ButtonTwo Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var compTwont = GetOrAddComponent<ObservableOnButtonTwoTouchStartTrigger>(controllerEvent.gameObject);
            controllerEvent.ButtonTwoTouchStart += compTwont.OnButtonTwoTouchStart;

            return compTwont.OnButtonTwoTouchStartAsObservable();
        }
        #endregion

        #region ObservableOnButtonTwoTouchEndTrigger
        /// <summary>
        /// Controller ButtonTwo Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var compTwont = GetOrAddComponent<ObservableOnButtonTwoTouchEndTrigger>(controllerEvent.gameObject);
            controllerEvent.ButtonTwoTouchEnd += compTwont.OnButtonTwoTouchEnd;

            return compTwont.OnButtonTwoTouchEndAsObservable();
        }
        #endregion

        #region ObservableOnStartMenuPressedTrigger
        /// <summary>
        /// Controller StartMenu Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnStartMenuPressedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var compTwont = GetOrAddComponent<ObservableOnStartMenuPressedTrigger>(controllerEvent.gameObject);
            controllerEvent.StartMenuPressed += compTwont.OnStartMenuPressed;

            return compTwont.OnStartMenuPressedAsObservable();
        }
        #endregion

        #region ObservableOnStartMenuReleasedTrigger
        /// <summary>
        /// Controller StartMenu Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnStartMenuReleasedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var compTwont = GetOrAddComponent<ObservableOnStartMenuReleasedTrigger>(controllerEvent.gameObject);
            controllerEvent.StartMenuReleased += compTwont.OnStartMenuReleased;

            return compTwont.OnStartMenuReleasedAsObservable();
        }
        #endregion

        #region ObservableOnMiddleFingerSenseAxisChangedTrigger
        /// <summary>
        ///  Controller MiddleFinger SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnMiddleFingerSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnMiddleFingerSenseAxisChangedTrigger>(controllerEvent.gameObject);
            controllerEvent.MiddleFingerSenseAxisChanged += component.OnMiddleFingerSenseAxisChanged;

            return component.OnMiddleFingerSenseAxisChangedAsObservable();
        }
        #endregion

        #region ObservableOnRingFingerSenseAxisChangedTrigger
        /// <summary>
        ///  Controller RingFinger SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnRingFingerSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnRingFingerSenseAxisChangedTrigger>(controllerEvent.gameObject);
            controllerEvent.RingFingerSenseAxisChanged += component.OnRingFingerSenseAxisChanged;

            return component.OnRingFingerSenseAxisChangedAsObservable();
        }
        #endregion

        #region ObservableOnPinkyFingerSenseAxisChangedTrigger
        /// <summary>
        ///  Controller PinkyFinger SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnPinkyFingerSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnPinkyFingerSenseAxisChangedTrigger>(controllerEvent.gameObject);
            controllerEvent.PinkyFingerSenseAxisChanged += component.OnPinkyFingerSenseAxisChanged;

            return component.OnPinkyFingerSenseAxisChangedAsObservable();
        }
        #endregion

        #region ObservableOnGripSenseAxisChangedTrigger
        /// <summary>
        ///  Controller Grip SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var component = GetOrAddComponent<ObservableOnGripSenseAxisChangedTrigger>(controllerEvent.gameObject);
            controllerEvent.GripSenseAxisChanged += component.OnGripSenseAxisChanged;

            return component.OnGripSenseAxisChangedAsObservable();
        }
        #endregion

        #region ObservableOnGripSensePressedTrigger
        /// <summary>
        /// Controller GripSense Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripSensePressedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var compTwont = GetOrAddComponent<ObservableOnGripSensePressedTrigger>(controllerEvent.gameObject);
            controllerEvent.GripSensePressed += compTwont.OnGripSensePressed;

            return compTwont.OnGripSensePressedAsObservable();
        }
        #endregion

        #region ObservableOnGripSenseReleasedTrigger
        /// <summary>
        /// Controller GripSense Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripSenseReleasedAsObservable(this VRTK_ControllerEvents controllerEvent)
        {
            var compTwont = GetOrAddComponent<ObservableOnGripSenseReleasedTrigger>(controllerEvent.gameObject);
            controllerEvent.GripSenseReleased += compTwont.OnGripSenseReleased;

            return compTwont.OnGripSenseReleasedAsObservable();
        }
        #endregion
        #endregion

        #region InteractableObject events

        #region ObservableOnIoTouchedTrigger
        /// <summary>
        /// Controller Io Touched
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoTouchedAsObservable(this VRTK_InteractableObject io)
        {
            var component = GetOrAddComponent<ObservableOnIoTouchedTrigger>(io.gameObject);
            io.InteractableObjectTouched += component.OnIoTouched;

            return component.OnIoTouchedAsObservable();
        }
        #endregion

        #region ObservableOnIoUntouchedTrigger
        /// <summary>
        /// Controller Io Untouched
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUntouchedAsObservable(this VRTK_InteractableObject io)
        {
            var component = GetOrAddComponent<ObservableOnIoUntouchedTrigger>(io.gameObject);
            io.InteractableObjectUntouched += component.OnIoUntouched;

            return component.OnIoUntouchedAsObservable();
        }
        #endregion

        #region ObservableOnIoGrabbedTrigger
        /// <summary>
        /// Controller Io Grabbed
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoGrabbedAsObservable(this VRTK_InteractableObject io)
        {
            var component = GetOrAddComponent<ObservableOnIoGrabbedTrigger>(io.gameObject);
            io.InteractableObjectGrabbed += component.OnIoGrabbed;

            return component.OnIoGrabbedAsObservable();
        }
        #endregion

        #region ObservableOnIoUngrabbedTrigger
        /// <summary>
        /// Controller Io Ungrabbed
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUngrabbedAsObservable(this VRTK_InteractableObject io)
        {
            var component = GetOrAddComponent<ObservableOnIoUngrabbedTrigger>(io.gameObject);
            io.InteractableObjectUngrabbed += component.OnIoUngrabbed;

            return component.OnIoUngrabbedAsObservable();
        }
        #endregion

        #region ObservableOnIoUsedTrigger
        /// <summary>
        /// Controller Io Used
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUsedAsObservable(this VRTK_InteractableObject io)
        {
            var component = GetOrAddComponent<ObservableOnIoUsedTrigger>(io.gameObject);
            io.InteractableObjectUsed += component.OnIoUsed;

            return component.OnIoUsedAsObservable();
        }
        #endregion

        #region ObservableOnIoUnusedTrigger
        /// <summary>
        /// Controller Io Unused
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUnusedAsObservable(this VRTK_InteractableObject io)
        {
            var component = GetOrAddComponent<ObservableOnIoUnusedTrigger>(io.gameObject);
            io.InteractableObjectUnused += component.OnIoUnused;

            return component.OnIoUnusedAsObservable();
        }
        #endregion

        #endregion

        private static T GetOrAddComponent<T>(GameObject gameObject)
            where T : Component
        {
            var component = gameObject.GetComponent<T>();
            if (component == null)
            {
                component = gameObject.AddComponent<T>();
            }

            return component;
        }
    }
}