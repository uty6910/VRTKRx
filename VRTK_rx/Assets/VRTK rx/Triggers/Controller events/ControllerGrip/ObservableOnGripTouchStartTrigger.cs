using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnGripTouchStartTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripTouchStart;

        public void OnGripTouchStart(object sender, ControllerInteractionEventArgs e)
        {
            if (onGripTouchStart != null)
            {
                onGripTouchStart.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripTouchStartAsObservable()
        {
            return onGripTouchStart ?? (onGripTouchStart = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onGripTouchStart != null)
            {
                onGripTouchStart.OnCompleted();
            }
        }
    }
}