using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnGripSenseReleasedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripSenseReleased;

        public void OnGripSenseReleased(object sender, ControllerInteractionEventArgs e)
        {
            if (onGripSenseReleased != null)
            {
                onGripSenseReleased.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripSenseReleasedAsObservable()
        {
            return onGripSenseReleased ?? (onGripSenseReleased = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onGripSenseReleased != null)
            {
                onGripSenseReleased.OnCompleted();
            }
        }
    }
}