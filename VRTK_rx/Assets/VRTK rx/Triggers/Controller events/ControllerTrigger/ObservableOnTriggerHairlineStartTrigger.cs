using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTriggerHairlineStartTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTriggerHairlineStart;

        public void OnTriggerHairlineStart(object sender, ControllerInteractionEventArgs e)
        {
            if (onTriggerHairlineStart != null)
            {
                onTriggerHairlineStart.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerHairlineStartAsObservable()
        {
            return onTriggerHairlineStart ?? (onTriggerHairlineStart = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTriggerHairlineStart != null)
            {
                onTriggerHairlineStart.OnCompleted();
            }
        }
    }
}