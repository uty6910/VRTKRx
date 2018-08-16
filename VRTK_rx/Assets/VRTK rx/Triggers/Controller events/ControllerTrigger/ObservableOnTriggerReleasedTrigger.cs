using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTriggerReleasedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTriggerReleased;

        public void OnTriggerReleased(object sender, ControllerInteractionEventArgs e)
        {
            if (onTriggerReleased != null)
            {
                onTriggerReleased.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerReleasedAsObservable()
        {
            return onTriggerReleased ?? (onTriggerReleased = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTriggerReleased != null)
            {
                onTriggerReleased.OnCompleted();
            }
        }
    }
}