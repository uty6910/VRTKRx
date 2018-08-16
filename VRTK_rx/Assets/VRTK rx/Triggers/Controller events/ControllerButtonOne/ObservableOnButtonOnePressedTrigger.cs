using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnButtonOnePressedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onButtonOnePressed;

        public void OnButtonOnePressed(object sender, ControllerInteractionEventArgs e)
        {
            if (onButtonOnePressed != null)
            {
                onButtonOnePressed.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOnePressedAsObservable()
        {
            return onButtonOnePressed ?? (onButtonOnePressed = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onButtonOnePressed != null)
            {
                onButtonOnePressed.OnCompleted();
            }
        }
    }
}