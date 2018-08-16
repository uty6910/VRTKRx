using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnGripSensePressedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripSensePressed;

        public void OnGripSensePressed(object sender, ControllerInteractionEventArgs e)
        {
            if (onGripSensePressed != null)
            {
                onGripSensePressed.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripSensePressedAsObservable()
        {
            return onGripSensePressed ?? (onGripSensePressed = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onGripSensePressed != null)
            {
                onGripSensePressed.OnCompleted();
            }
        }
    }
}