using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTriggerPressedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTriggerPressed;

        public void OnTriggerPressed(object sender, ControllerInteractionEventArgs e)
        {
            if (onTriggerPressed != null)
            {
                onTriggerPressed.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerPressedAsObservable()
        {
            return onTriggerPressed ?? (onTriggerPressed = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTriggerPressed != null)
            {
                onTriggerPressed.OnCompleted();
            }
        }
    }
}