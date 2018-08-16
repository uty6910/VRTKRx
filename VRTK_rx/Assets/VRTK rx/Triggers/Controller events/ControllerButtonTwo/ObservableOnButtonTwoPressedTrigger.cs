using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnButtonTwoPressedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onButtonTwoPressed;

        public void OnButtonTwoPressed(object sender, ControllerInteractionEventArgs e)
        {
            if (onButtonTwoPressed != null)
            {
                onButtonTwoPressed.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoPressedAsObservable()
        {
            return onButtonTwoPressed ?? (onButtonTwoPressed = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onButtonTwoPressed != null)
            {
                onButtonTwoPressed.OnCompleted();
            }
        }
    }
}