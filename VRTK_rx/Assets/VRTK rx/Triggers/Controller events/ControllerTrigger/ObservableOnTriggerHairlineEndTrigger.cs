using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTriggerHairlineEndTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTriggerHairlineEnd;

        public void OnTriggerHairlineEnd(object sender, ControllerInteractionEventArgs e)
        {
            if (onTriggerHairlineEnd != null)
            {
                onTriggerHairlineEnd.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerHairlineEndAsObservable()
        {
            return onTriggerHairlineEnd ?? (onTriggerHairlineEnd = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTriggerHairlineEnd != null)
            {
                onTriggerHairlineEnd.OnCompleted();
            }
        }
    }
}