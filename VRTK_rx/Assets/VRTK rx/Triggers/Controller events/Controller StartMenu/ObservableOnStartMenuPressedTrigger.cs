using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnStartMenuPressedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onStartMenuPressed;

        public void OnStartMenuPressed(object sender, ControllerInteractionEventArgs e)
        {
            if (onStartMenuPressed != null)
            {
                onStartMenuPressed.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnStartMenuPressedAsObservable()
        {
            return onStartMenuPressed ?? (onStartMenuPressed = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onStartMenuPressed != null)
            {
                onStartMenuPressed.OnCompleted();
            }
        }
    }
}