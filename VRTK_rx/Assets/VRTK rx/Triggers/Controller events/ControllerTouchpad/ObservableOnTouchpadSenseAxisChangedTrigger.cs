using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTouchpadSenseAxisChangedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadSenseAxisChanged;

        public void OnTouchpadSenseAxisChanged(object sender, ControllerInteractionEventArgs e)
        {
            if (onTouchpadSenseAxisChanged != null)
            {
                onTouchpadSenseAxisChanged.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadSenseAxisChangedAsObservable()
        {
            return onTouchpadSenseAxisChanged ?? (onTouchpadSenseAxisChanged = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTouchpadSenseAxisChanged != null)
            {
                onTouchpadSenseAxisChanged.OnCompleted();
            }
        }
    }
}