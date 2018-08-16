using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnGripSenseAxisChangedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripSenseAxisChanged;

        public void OnGripSenseAxisChanged(object sender, ControllerInteractionEventArgs e)
        {
            if (onGripSenseAxisChanged != null)
            {
                onGripSenseAxisChanged.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripSenseAxisChangedAsObservable()
        {
            return onGripSenseAxisChanged ?? (onGripSenseAxisChanged = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onGripSenseAxisChanged != null)
            {
                onGripSenseAxisChanged.OnCompleted();
            }
        }
    }
}