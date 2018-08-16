using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTriggerUnclickedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTriggerUnclicked;

        public void OnTriggerUnclicked(object sender, ControllerInteractionEventArgs e)
        {
            if (onTriggerUnclicked != null)
            {
                onTriggerUnclicked.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerUnclickedAsObservable()
        {
            return onTriggerUnclicked ?? (onTriggerUnclicked = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTriggerUnclicked != null)
            {
                onTriggerUnclicked.OnCompleted();
            }
        }
    }
}