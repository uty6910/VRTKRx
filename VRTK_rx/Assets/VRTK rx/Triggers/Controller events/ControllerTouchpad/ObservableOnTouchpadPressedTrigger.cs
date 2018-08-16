using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTouchpadPressedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadPressed;

        public void OnTouchpadPressed(object sender, ControllerInteractionEventArgs e)
        {
            if (onTouchpadPressed != null)
            {
                onTouchpadPressed.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadPressedAsObservable()
        {
            return onTouchpadPressed ?? (onTouchpadPressed = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTouchpadPressed != null)
            {
                onTouchpadPressed.OnCompleted();
            }
        }
    }
}