using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnGripPressedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripPressed;

        public void OnGripPressed(object sender, ControllerInteractionEventArgs e)
        {
            if (onGripPressed != null)
            {
                onGripPressed.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripPressedAsObservable()
        {
            return onGripPressed ?? (onGripPressed = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onGripPressed != null)
            {
                onGripPressed.OnCompleted();
            }
        }
    }
}