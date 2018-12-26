using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using VRTK;
using VrtkRx.Triggers;

namespace VrtkRx {

    public static class VrtkRxObservableTriggers {

        #region Controller events

        #region ObservableOnTriggerPressedTrigger

        /// <summary>
        /// Controller Trigger Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerPressedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTriggerPressedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TriggerPressed += component.OnTriggerPressed;

            return component.OnTriggerPressedAsObservable();
        }

        #endregion ObservableOnTriggerPressedTrigger

        #region ObservableOnTriggerReleasedTrigger

        /// <summary>
        /// Controller Trigger Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerReleasedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTriggerReleasedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TriggerReleased += component.OnTriggerReleased;

            return component.OnTriggerReleasedAsObservable();
        }

        #endregion ObservableOnTriggerReleasedTrigger

        #region ObservableOnTriggerTouchStartTrigger

        /// <summary>
        /// Controller Trigger Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTriggerTouchStartTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TriggerTouchStart += component.OnTriggerTouchStart;

            return component.OnTriggerTouchStartAsObservable();
        }

        #endregion ObservableOnTriggerTouchStartTrigger

        #region ObservableOnTriggerTouchEndTrigger

        /// <summary>
        /// Controller Trigger Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTriggerTouchEndTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TriggerTouchEnd += component.OnTriggerTouchEnd;

            return component.OnTriggerTouchEndAsObservable();
        }

        #endregion ObservableOnTriggerTouchEndTrigger

        #region ObservableOnTriggerHairlineStartTrigger

        /// <summary>
        ///  Controller Trigger Hairline Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerHairlineStartAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTriggerHairlineStartTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TriggerHairlineStart += component.OnTriggerHairlineStart;

            return component.OnTriggerHairlineStartAsObservable();
        }

        #endregion ObservableOnTriggerHairlineStartTrigger

        #region ObservableOnTriggerHairlineEndTrigger

        /// <summary>
        ///  Controller Trigger Hairline End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerHairlineEndAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTriggerHairlineEndTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TriggerHairlineEnd += component.OnTriggerHairlineEnd;

            return component.OnTriggerHairlineEndAsObservable();
        }

        #endregion ObservableOnTriggerHairlineEndTrigger

        #region ObservableOnTriggerClickedTrigger

        /// <summary>
        ///  Controller Trigger Clicked
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerClickedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTriggerClickedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TriggerClicked += component.OnTriggerClicked;

            return component.OnTriggerClickedAsObservable();
        }

        #endregion ObservableOnTriggerClickedTrigger

        #region ObservableOnTriggerUnclickedTrigger

        /// <summary>
        ///  Controller Trigger Unclicked
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerUnclickedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTriggerUnclickedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TriggerUnclicked += component.OnTriggerUnclicked;

            return component.OnTriggerUnclickedAsObservable();
        }

        #endregion ObservableOnTriggerUnclickedTrigger

        #region ObservableOnTriggerAxisChangedTrigger

        /// <summary>
        ///  Controller Trigger AxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTriggerAxisChangedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TriggerAxisChanged += component.OnTriggerAxisChanged;

            return component.OnTriggerAxisChangedAsObservable();
        }

        #endregion ObservableOnTriggerAxisChangedTrigger

        #region ObservableOnTriggerSenseAxisChangedTrigger

        /// <summary>
        ///  Controller Trigger SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTriggerSenseAxisChangedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TriggerSenseAxisChanged += component.OnTriggerSenseAxisChanged;

            return component.OnTriggerSenseAxisChangedAsObservable();
        }

        #endregion ObservableOnTriggerSenseAxisChangedTrigger

        #region ObservableOnGripPressedTrigger

        /// <summary>
        /// Controller Grip Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripPressedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripPressedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripPressed += component.OnGripPressed;

            return component.OnGripPressedAsObservable();
        }

        #endregion ObservableOnGripPressedTrigger

        #region ObservableOnGripReleasedTrigger

        /// <summary>
        /// Controller Grip Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripReleasedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripReleasedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripReleased += component.OnGripReleased;

            return component.OnGripReleasedAsObservable();
        }

        #endregion ObservableOnGripReleasedTrigger

        #region ObservableOnGripTouchStartTrigger

        /// <summary>
        /// Controller Grip Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripTouchStartTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripTouchStart += component.OnGripTouchStart;

            return component.OnGripTouchStartAsObservable();
        }

        #endregion ObservableOnGripTouchStartTrigger

        #region ObservableOnGripTouchEndTrigger

        /// <summary>
        /// Controller Grip Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripTouchEndTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripTouchEnd += component.OnGripTouchEnd;

            return component.OnGripTouchEndAsObservable();
        }

        #endregion ObservableOnGripTouchEndTrigger

        #region ObservableOnGripHairlineStartTrigger

        /// <summary>
        ///  Controller Grip Hairline Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripHairlineStartAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripHairlineStartTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripHairlineStart += component.OnGripHairlineStart;

            return component.OnGripHairlineStartAsObservable();
        }

        #endregion ObservableOnGripHairlineStartTrigger

        #region ObservableOnGripHairlineEndTrigger

        /// <summary>
        ///  Controller Grip Hairline End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripHairlineEndAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripHairlineEndTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripHairlineEnd += component.OnGripHairlineEnd;

            return component.OnGripHairlineEndAsObservable();
        }

        #endregion ObservableOnGripHairlineEndTrigger

        #region ObservableOnGripClickedTrigger

        /// <summary>
        ///  Controller Grip Clicked
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripClickedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripClickedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripClicked += component.OnGripClicked;

            return component.OnGripClickedAsObservable();
        }

        #endregion ObservableOnGripClickedTrigger

        #region ObservableOnGripUnclickedTrigger

        /// <summary>
        ///  Controller Grip Unclicked
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripUnclickedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripUnclickedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripUnclicked += component.OnGripUnclicked;

            return component.OnGripUnclickedAsObservable();
        }

        #endregion ObservableOnGripUnclickedTrigger

        #region ObservableOnGripAxisChangedTrigger

        /// <summary>
        ///  Controller Grip AxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripAxisChangedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripAxisChanged += component.OnGripAxisChanged;

            return component.OnGripAxisChangedAsObservable();
        }

        #endregion ObservableOnGripAxisChangedTrigger

        #region ObservableOnTouchpadPressedTrigger

        /// <summary>
        /// Controller Touchpad Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadPressedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadPressedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadPressed += component.OnTouchpadPressed;

            return component.OnTouchpadPressedAsObservable();
        }

        #endregion ObservableOnTouchpadPressedTrigger

        #region ObservableOnTouchpadReleasedTrigger

        /// <summary>
        /// Controller Touchpad Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadReleasedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadReleasedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadReleased += component.OnTouchpadReleased;

            return component.OnTouchpadReleasedAsObservable();
        }

        #endregion ObservableOnTouchpadReleasedTrigger

        #region ObservableOnTouchpadTouchStartTrigger

        /// <summary>
        /// Controller Touchpad Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadTouchStartTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadTouchStart += component.OnTouchpadTouchStart;

            return component.OnTouchpadTouchStartAsObservable();
        }

        #endregion ObservableOnTouchpadTouchStartTrigger

        #region ObservableOnTouchpadTouchEndTrigger

        /// <summary>
        /// Controller Touchpad Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadTouchEndTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadTouchEnd += component.OnTouchpadTouchEnd;

            return component.OnTouchpadTouchEndAsObservable();
        }

        #endregion ObservableOnTouchpadTouchEndTrigger

        #region ObservableOnTouchpadAxisChangedTrigger

        /// <summary>
        ///  Controller Touchpad AxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadAxisChangedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadAxisChanged += component.OnTouchpadAxisChanged;

            return component.OnTouchpadAxisChangedAsObservable();
        }

        #endregion ObservableOnTouchpadAxisChangedTrigger

        #region ObservableOnTouchpadSenseAxisChangedTrigger

        /// <summary>
        ///  Controller Touchpad SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadSenseAxisChangedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadSenseAxisChanged += component.OnTouchpadSenseAxisChanged;

            return component.OnTouchpadSenseAxisChangedAsObservable();
        }

        #endregion ObservableOnTouchpadSenseAxisChangedTrigger

        #region ObservableOnTouchpadTwoPressedTrigger

        /// <summary>
        /// Controller TouchpadTwo Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoPressedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadTwoPressedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadTwoPressed += component.OnTouchpadTwoPressed;

            return component.OnTouchpadTwoPressedAsObservable();
        }

        #endregion ObservableOnTouchpadTwoPressedTrigger

        #region ObservableOnTouchpadTwoReleasedTrigger

        /// <summary>
        /// Controller TouchpadTwo Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoReleasedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadTwoReleasedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadTwoReleased += component.OnTouchpadTwoReleased;

            return component.OnTouchpadTwoReleasedAsObservable();
        }

        #endregion ObservableOnTouchpadTwoReleasedTrigger

        #region ObservableOnTouchpadTwoTouchStartTrigger

        /// <summary>
        /// Controller TouchpadTwo Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadTwoTouchStartTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadTwoTouchStart += component.OnTouchpadTwoTouchStart;

            return component.OnTouchpadTwoTouchStartAsObservable();
        }

        #endregion ObservableOnTouchpadTwoTouchStartTrigger

        #region ObservableOnTouchpadTwoTouchEndTrigger

        /// <summary>
        /// Controller TouchpadTwo Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadTwoTouchEndTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadTwoTouchEnd += component.OnTouchpadTwoTouchEnd;

            return component.OnTouchpadTwoTouchEndAsObservable();
        }

        #endregion ObservableOnTouchpadTwoTouchEndTrigger

        #region ObservableOnTouchpadTwoAxisChangedTrigger

        /// <summary>
        ///  Controller TouchpadTwo AxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnTouchpadTwoAxisChangedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.TouchpadTwoAxisChanged += component.OnTouchpadTwoAxisChanged;

            return component.OnTouchpadTwoAxisChangedAsObservable();
        }

        #endregion ObservableOnTouchpadTwoAxisChangedTrigger

        #region ObservableOnButtonOnePressedTrigger

        /// <summary>
        /// Controller ButtonOne Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOnePressedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnButtonOnePressedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.ButtonOnePressed += component.OnButtonOnePressed;

            return component.OnButtonOnePressedAsObservable();
        }

        #endregion ObservableOnButtonOnePressedTrigger

        #region ObservableOnButtonOneReleasedTrigger

        /// <summary>
        /// Controller ButtonOne Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOneReleasedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnButtonOneReleasedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.ButtonOneReleased += component.OnButtonOneReleased;

            return component.OnButtonOneReleasedAsObservable();
        }

        #endregion ObservableOnButtonOneReleasedTrigger

        #region ObservableOnButtonOneTouchStartTrigger

        /// <summary>
        /// Controller ButtonOne Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOneTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnButtonOneTouchStartTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.ButtonOneTouchStart += component.OnButtonOneTouchStart;

            return component.OnButtonOneTouchStartAsObservable();
        }

        #endregion ObservableOnButtonOneTouchStartTrigger

        #region ObservableOnButtonOneTouchEndTrigger

        /// <summary>
        /// Controller ButtonOne Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOneTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnButtonOneTouchEndTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.ButtonOneTouchEnd += component.OnButtonOneTouchEnd;

            return component.OnButtonOneTouchEndAsObservable();
        }

        #endregion ObservableOnButtonOneTouchEndTrigger

        #region ObservableOnButtonTwoPressedTrigger

        /// <summary>
        /// Controller ButtonTwo Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoPressedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnButtonTwoPressedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.ButtonTwoPressed += component.OnButtonTwoPressed;

            return component.OnButtonTwoPressedAsObservable();
        }

        #endregion ObservableOnButtonTwoPressedTrigger

        #region ObservableOnButtonTwoReleasedTrigger

        /// <summary>
        /// Controller ButtonTwo Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoReleasedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnButtonTwoReleasedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.ButtonTwoReleased += component.OnButtonTwoReleased;

            return component.OnButtonTwoReleasedAsObservable();
        }

        #endregion ObservableOnButtonTwoReleasedTrigger

        #region ObservableOnButtonTwoTouchStartTrigger

        /// <summary>
        /// Controller ButtonTwo Touch Start
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoTouchStartAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnButtonTwoTouchStartTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.ButtonTwoTouchStart += component.OnButtonTwoTouchStart;

            return component.OnButtonTwoTouchStartAsObservable();
        }

        #endregion ObservableOnButtonTwoTouchStartTrigger

        #region ObservableOnButtonTwoTouchEndTrigger

        /// <summary>
        /// Controller ButtonTwo Touch End
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoTouchEndAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnButtonTwoTouchEndTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.ButtonTwoTouchEnd += component.OnButtonTwoTouchEnd;

            return component.OnButtonTwoTouchEndAsObservable();
        }

        #endregion ObservableOnButtonTwoTouchEndTrigger

        #region ObservableOnStartMenuPressedTrigger

        /// <summary>
        /// Controller StartMenu Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnStartMenuPressedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnStartMenuPressedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.StartMenuPressed += component.OnStartMenuPressed;

            return component.OnStartMenuPressedAsObservable();
        }

        #endregion ObservableOnStartMenuPressedTrigger

        #region ObservableOnStartMenuReleasedTrigger

        /// <summary>
        /// Controller StartMenu Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnStartMenuReleasedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnStartMenuReleasedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.StartMenuReleased += component.OnStartMenuReleased;

            return component.OnStartMenuReleasedAsObservable();
        }

        #endregion ObservableOnStartMenuReleasedTrigger

        #region ObservableOnMiddleFingerSenseAxisChangedTrigger

        /// <summary>
        ///  Controller MiddleFinger SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnMiddleFingerSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnMiddleFingerSenseAxisChangedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.MiddleFingerSenseAxisChanged += component.OnMiddleFingerSenseAxisChanged;

            return component.OnMiddleFingerSenseAxisChangedAsObservable();
        }

        #endregion ObservableOnMiddleFingerSenseAxisChangedTrigger

        #region ObservableOnRingFingerSenseAxisChangedTrigger

        /// <summary>
        ///  Controller RingFinger SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnRingFingerSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnRingFingerSenseAxisChangedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.RingFingerSenseAxisChanged += component.OnRingFingerSenseAxisChanged;

            return component.OnRingFingerSenseAxisChangedAsObservable();
        }

        #endregion ObservableOnRingFingerSenseAxisChangedTrigger

        #region ObservableOnPinkyFingerSenseAxisChangedTrigger

        /// <summary>
        ///  Controller PinkyFinger SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnPinkyFingerSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnPinkyFingerSenseAxisChangedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.PinkyFingerSenseAxisChanged += component.OnPinkyFingerSenseAxisChanged;

            return component.OnPinkyFingerSenseAxisChangedAsObservable();
        }

        #endregion ObservableOnPinkyFingerSenseAxisChangedTrigger

        #region ObservableOnGripSenseAxisChangedTrigger

        /// <summary>
        ///  Controller Grip SenseAxisChanged
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripSenseAxisChangedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripSenseAxisChangedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripSenseAxisChanged += component.OnGripSenseAxisChanged;

            return component.OnGripSenseAxisChangedAsObservable();
        }

        #endregion ObservableOnGripSenseAxisChangedTrigger

        #region ObservableOnGripSensePressedTrigger

        /// <summary>
        /// Controller GripSense Pressed
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripSensePressedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripSensePressedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripSensePressed += component.OnGripSensePressed;

            return component.OnGripSensePressedAsObservable();
        }

        #endregion ObservableOnGripSensePressedTrigger

        #region ObservableOnGripSenseReleasedTrigger

        /// <summary>
        /// Controller GripSense Released
        /// </summary>
        public static IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripSenseReleasedAsObservable(this VRTK_ControllerEvents controllerEvent) {
            var component = GetOrAddComponent<ObservableOnGripSenseReleasedTrigger>(controllerEvent.gameObject);
            component.ob = controllerEvent;
            controllerEvent.GripSenseReleased += component.OnGripSenseReleased;

            return component.OnGripSenseReleasedAsObservable();
        }

        #endregion ObservableOnGripSenseReleasedTrigger

        #endregion Controller events

        #region InteractableObject events

        #region ObservableOnIoTouchedTrigger

        /// <summary>
        /// Controller Io Touched
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoTouchedAsObservable(this VRTK_InteractableObject io) {
            var component = GetOrAddComponent<ObservableOnIoTouchedTrigger>(io.gameObject);
            component.ob = io;
            io.InteractableObjectTouched += component.OnIoTouched;

            return component.OnIoTouchedAsObservable();
        }

        #endregion ObservableOnIoTouchedTrigger

        #region ObservableOnIoUntouchedTrigger

        /// <summary>
        /// Controller Io Untouched
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUntouchedAsObservable(this VRTK_InteractableObject io) {
            var component = GetOrAddComponent<ObservableOnIoUntouchedTrigger>(io.gameObject);
            component.ob = io;
            io.InteractableObjectUntouched += component.OnIoUntouched;

            return component.OnIoUntouchedAsObservable();
        }

        #endregion ObservableOnIoUntouchedTrigger

        #region ObservableOnIoGrabbedTrigger

        /// <summary>
        /// Controller Io Grabbed
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoGrabbedAsObservable(this VRTK_InteractableObject io) {
            var component = GetOrAddComponent<ObservableOnIoGrabbedTrigger>(io.gameObject);
            component.ob = io;
            io.InteractableObjectGrabbed += component.OnIoGrabbed;

            return component.OnIoGrabbedAsObservable();
        }

        #endregion ObservableOnIoGrabbedTrigger

        #region ObservableOnIoUngrabbedTrigger

        /// <summary>
        /// Controller Io Ungrabbed
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUngrabbedAsObservable(this VRTK_InteractableObject io) {
            var component = GetOrAddComponent<ObservableOnIoUngrabbedTrigger>(io.gameObject);
            component.ob = io;
            io.InteractableObjectUngrabbed += component.OnIoUngrabbed;

            return component.OnIoUngrabbedAsObservable();
        }

        #endregion ObservableOnIoUngrabbedTrigger

        #region ObservableOnIoUsedTrigger

        /// <summary>
        /// Controller Io Used
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUsedAsObservable(this VRTK_InteractableObject io) {
            var component = GetOrAddComponent<ObservableOnIoUsedTrigger>(io.gameObject);
            component.ob = io;
            io.InteractableObjectUsed += component.OnIoUsed;

            return component.OnIoUsedAsObservable();
        }

        #endregion ObservableOnIoUsedTrigger

        #region ObservableOnIoUnusedTrigger

        /// <summary>
        /// Controller Io Unused
        /// </summary>
        public static IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUnusedAsObservable(this VRTK_InteractableObject io) {
            var component = GetOrAddComponent<ObservableOnIoUnusedTrigger>(io.gameObject);
            component.ob = io;
            io.InteractableObjectUnused += component.OnIoUnused;

            return component.OnIoUnusedAsObservable();
        }

        #endregion ObservableOnIoUnusedTrigger

        #region ObservableOnHighlighterTrigger

        public static IObservable<Tuple<object, InteractObjectHighlighterEventArgs>> OnHighlighterObservable(this VRTK_InteractObjectHighlighter high) {
            var component = GetOrAddComponent<ObservableOnHighlighterTrigger>(high.gameObject);
            component.ob = high;
            high.InteractObjectHighlighterHighlighted += component.OnHighligted;

            return component.OnHighlighterAsObservable();
        }

        #endregion ObservableOnHighlighterTrigger

        #endregion InteractableObject events

        private static T GetOrAddComponent<T>(GameObject gameObject)
            where T : Component {
            var component = gameObject.GetComponent<T>();
            if (component == null) {
                component = gameObject.AddComponent<T>();
            }

            return component;
        }
    }
}